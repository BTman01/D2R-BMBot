using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;


namespace app.Newint
{


    public partial class Dashboard : Form
    {
        //Various Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Dashboard()

        {
            InitializeComponent();
            random = new Random(); // Initialize the Random object
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Please select an image file:");
            string filePath = Console.ReadLine();

            await DetectScene(filePath);
        }

        static async Task DetectScene(string filePath)
        {
            using (var content = new MultipartFormDataContent())
            {
                // Use FileStream for asynchronous read
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    byte[] fileBytes = new byte[stream.Length];
                    await stream.ReadAsync(fileBytes, 0, (int)stream.Length);
                    content.Add(new ByteArrayContent(fileBytes), "image", Path.GetFileName(filePath));
                }

                HttpResponseMessage response = await client.PostAsync("http://localhost:32168/v1/vision/detect/scene", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                    Console.WriteLine($"Scene is {data.label}, {data.confidence} confidence");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }
        private void Activatebutton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Disablebutton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Disablebutton()
        {
            foreach (Control previousBtn in Menupanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object Sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Activatebutton(Sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Childpanel.Controls.Add(childForm);
            this.Childpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.Dashboard(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormDebug(), sender);
        }

        private void BotSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

        private void ItemsCubeSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

        private void D2LODHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Newint.FormBotSettings(), sender);
        }

    }
}