using NLog;

namespace NotificationApplication.Services
{
    public class FeaturesService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private FormMain mainForm;
        private QuoteService quoteService;

        public FeaturesService(FormMain mainForm)
        {
            this.mainForm = mainForm;
            quoteService = new QuoteService();
        }

        public void Features(string message)
        {
            switch (message.ToLower())
            {
                case "$451":
                    Feature451();
                    return;
                case "$451°":
                    Feature451();
                    return;
                case "$стэтхем":
                    FeatureStatham();
                    return;
                case "$стетхем":
                    FeatureStatham();
                    return;
                case "$стэйтем":
                    FeatureStatham();
                    return;
            }
        }

        public void Feature451()
        {
            mainForm.BackColor = Color.OrangeRed;
            logger.Info("Изменение цвета фона.");

            var imagePath = "..\\..\\..\\Resources\\BurningPaper.png";
            ChangeImagePictureBox(imagePath);

            mainForm.ClearAndFillRichTextBox("Ну вот и всё, всё сгорело. \n ❝ 451 градус по Фаренгейту — температура, при которой воспламеняется и горит бумага. ❞");
        }

        public void FeatureStatham()
        {
            var text = quoteService.GetRandomQuote();
            logger.Debug("Получен текст.");

            mainForm.BackColor = Color.WhiteSmoke;
            logger.Debug("Изменение фона pictureBox.");

            var imagePath = "..\\..\\..\\Resources\\Statham.png";
            ChangeImagePictureBox(imagePath);

            mainForm.ClearAndFillRichTextBox(text);
        }

        private void ChangeImagePictureBox(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                mainForm.pictureBox.Image = Image.FromFile(imagePath);
                logger.Debug("Изменение фона pictureBox.");
                return;
            }
            else
            {
                mainForm.pictureBox.Image = null;
                logger.Debug("Очистка фона pictureBox.");
                logger.Error($"Изображение не найдено: {imagePath}");
                return;
            }
        }
    }
}
