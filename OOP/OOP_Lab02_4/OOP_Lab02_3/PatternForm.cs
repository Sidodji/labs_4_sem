using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Lab02_3.AbstractFactory;
using OOP_Lab02_3.Builder;
using OOP_Lab02_3.Singleton;
using OOP_Lab02_3.Protorype;
using OOP_Lab02_3.Memento;

namespace OOP_Lab02_3
{
    public partial class PatternForm : Form
    {
        

        public PatternForm()
        {
            InitializeComponent();
        }

       

        private void buttonClearArea(object sender, EventArgs e)
        {
            richTextBox.Clear();
            richTextBox.Update();
        }
        //абстрактня фабрика
        private void AbstractFactory_Click(object sender, EventArgs e)
        {
            AbstractFactory.Client client = new AbstractFactory.Client();
            client.Event += new AbstractFactory.ClientEventHandler(PatternForm_EventHandler);

            client.Main();
        }

        public void PatternForm_EventHandler(string message)
        {
            richTextBox.Text += $"{message}\n";
        }
        //строитель
        private void BuilderForm_click(object sender, EventArgs e)
        {
            var bldDirector = new BuilderDirector();
            var bldBuilder = new FormBuilder();

            bldDirector.Builder = bldBuilder;
            bldDirector.BuildForm();
        }

        private void BuilderButton_click(object sender, EventArgs e)
        {
            var bldDirector = new BuilderDirector();
            var bldBuilder = new FormBuilder();

            bldDirector.Builder = bldBuilder;
            bldDirector.BuildButton();
        }
        //синглетон
        public void btnSingleton_click(object sender, EventArgs e)
        {
            var userConfig1 = FormConfiguration.GetInstance();
            userConfig1.ClientSize = new Size(579, 1234);
            userConfig1.Name = "Examle";

            var userConfig2 = FormConfiguration.GetInstance();
            userConfig2.ClientSize = new Size(100, 100);
            userConfig2.Name = "Example 2";

            PatternForm_EventHandler($"UserConfig1\n"+ $"Размер: {userConfig1.ClientSize}" + $"название:{userConfig1.Name} ");
            PatternForm_EventHandler($"UserConfig2\n"+$"Размер: {userConfig2.ClientSize}" + $"название:{userConfig2.Name} ");
        }

        private void Prototype_Click(object sender, EventArgs e)
        {

            IPrototype user = new User("person", 19);
            IPrototype clonedUser = user.Clone();
            IPrototype admin = new Admin("admin", "job");
            IPrototype cloneAdmin = admin.Clone();
        }
        //Адаптер

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            Adapter.Client client = new Adapter.Client();
            client.Event += new Adapter.AdapterEvents(PatternForm_EventHandler);
            client.Main();
        }
        //Мементо

        Command command;
        Car car;

        private void PatternsForm_Load(object sender, EventArgs e)
        {
            command = new Command();
            command.Event += new MementoEvent(PatternForm_EventHandler);
        }

        private void ObjCar1_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Event += new MementoEvent(PatternForm_EventHandler);

            car.SetName("Mers");
            car.SetColor("Black");
            car.SetSpeed(60);

            command.MakeBackup(car);
        }

        private void ObjCar2_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Event += new MementoEvent(PatternForm_EventHandler);

            car.SetName("Peugeot");
            car.SetColor("red");
            car.SetSpeed(40);
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            command.Undo(ref car);
            PatternForm_EventHandler($"\nCar name: {car.Name}\nCar color: {car.Color}\nCar speed: {car.Speed}");
        }
    }
}
