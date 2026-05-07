using NotificationApplication.Classes;
using NotificationApplication.HelperClasses;
using NotificationApplication.Services;
using Ninject;
using NLog;

namespace NotificationApplication
{
    public partial class FormMain : Form
    {
        private static Logger logger;
        private NotificationServiceNamesProvider notificationServiceNamesProvider { get; set; }
        private FeaturesService featureService { get; set; }

        public FormMain(IKernel kernel)
        {
            notificationServiceNamesProvider = new NotificationServiceNamesProvider(kernel);
            featureService = new FeaturesService(this);

            InitializeComponent();
            this.Load += FormMain_Load;
        }

        private void loadDataInComboBox()
        {
            var names = notificationServiceNamesProvider.GetAllNames();

            comboBoxSelectNotification.Items.Clear();
            logger.Debug("Очистка элемента comboBoxSelectNotification");
            foreach (var name in names)
            {
                comboBoxSelectNotification.Items.Add(name);
                logger.Trace($"В comboBoxSelectNotification добавлен item: {name}");
            }
            logger.Debug("Произошло заполнение comboBoxSelectNotification элементами");
            logger.Info("Очистка и загрузка данных в comboBox");
        }

        private void buttonSendNotification_Click(object sender, EventArgs e)
        {
            ResetDesignElements();

            try
            {
                logger.Debug("Нажатие кнопки");
                var message = textBoxInput.Text;
                logger.Trace($"Получен текст из textBoxInput: {message}");

                if (string.IsNullOrWhiteSpace(message))
                {
                    logger.Error("Пустой textBoxInput");
                    MessageBox.Show("Сообщение не может быть пустым.");
                    return;
                }

                var nameService = (string)comboBoxSelectNotification.SelectedItem;
                logger.Trace($"Получено название сервиса: {nameService}");

                if (nameService is null)
                {
                    logger.Error("Пустой comboBoxSelectNotification");
                    MessageBox.Show("Тип уведомления не может быть пустым.");
                    return;
                }

                var service = notificationServiceNamesProvider.GetServiceByName(nameService);

                var notificationSender = new NotificationSender(service);
                notificationSender.Send(message);

                featureService.Features(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (logger is null) logger = LogManager.GetCurrentClassLogger();

            loadDataInComboBox();
        }

        public void ClearAndFillRichTextBox(string message)
        {
            richTextBox.Clear();
            richTextBox.Text = message;
        }

        private void ResetDesignElements()
        {
            richTextBox.Clear();
            logger.Debug("Очистка richTextBox.");
            pictureBox.Image = null;
            logger.Debug("Очистка фона pictureBox.");
            this.BackColor = Color.White;
            logger.Debug("Изменение цвета фона.");
        }
    }
}
