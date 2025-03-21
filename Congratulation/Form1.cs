using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Imaging;
using Congratulation.Entities;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
namespace Congratulation
{
    public partial class Form1 : Form
    {
        private Color selectedTextColor = Color.Black;
        private string selectedFontName = "Andalus"; // Default font
        private string selectedFormate = "jpg"; // Default font
        private float selectedFontSize = 14; // Default font size
        private FontStyle selectedFontStyle = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkDb_Click(object sender, EventArgs e)
        {

            string dbType = "SQLServer"; // Change to "Oracle" as needed
            if (Oracle.Checked) dbType = "Oracle";
            string connectionString = conn.Text;// GetConnectionString(dbType);


            // Create DbContext instance dynamically
            using (var context = new AppDbContext(dbType, connectionString))
            {
                try
                {
                    context.Database.EnsureCreated();
                    MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select a folder";
                folderBrowserDialog1.ShowNewFolderButton = true; // Allow creating new folders

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog())
            {
                folderBrowserDialog2.Description = "Select a folder";
                folderBrowserDialog2.ShowNewFolderButton = true; // Allow creating new folders

                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = folderBrowserDialog2.SelectedPath;
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Please Click Load Data First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblProgress.Text = $"Processed:  ";
            lblProgress.Refresh();
            if (txtFolderPath.Text == "" || txtOutputPath.Text == "")
            {
                MessageBox.Show("Please select folder path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(txtFolderPath.Text + "\\male." + formate.SelectedItem.ToString()))
            {
                MessageBox.Show("لا يوجد قالب باسم male." + formate.SelectedItem.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(txtFolderPath.Text + "\\female1." + formate.SelectedItem.ToString()))
            {
                MessageBox.Show("لا يوجد قالب باسم female1." + formate.SelectedItem.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(txtFolderPath.Text + "\\female1." + formate.SelectedItem.ToString()))
            {
                MessageBox.Show("لا يوجد قالب باسم female2." + formate.SelectedItem.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string dbType = Oracle.Checked ? "Oracle" : "SQLServer";
            string connectionString = conn.Text;


            // Ensure output directory exists
            string outputFolder = txtOutputPath.Text;
            if (!System.IO.Directory.Exists(outputFolder))
            {
                System.IO.Directory.CreateDirectory(outputFolder);
            }

            try
            {
                using (var context = new AppDbContext(dbType, connectionString))
                {
                    if (!await context.Database.CanConnectAsync())
                    {
                        MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (radioButton1.Checked)
                    {
                        var employees = await context.Employees.Where(x => x.Id == Convert.ToUInt32(comboBox1.SelectedValue)).FirstOrDefaultAsync();
                        createCurrentEmp(employees);
                        return;
                    }
                    // Get total employee count for progress tracking
                    int totalEmployees = await context.Employees.CountAsync();
                    progressBar1.Maximum = totalEmployees;
                    progressBar1.Value = 0;

                    int batchSize = 500; // Process in batches
                    int processed = 0;

                    while (true)
                    {
                        var employees = await context.Employees
                            .AsNoTracking()
                            .OrderBy(e => e.Id)
                            .Skip(processed)
                            .Take(batchSize)
                            .ToListAsync();

                        if (!employees.Any())
                            break; // Stop if no more employees

                        foreach (var emp in employees)
                        {
                            string imagePath = $"{outputFolder}\\{emp.Id}.{selectedFormate}";
                            CreateImage(emp, imagePath);

                            // Update database with image path
                            var updateEmployee = new Employee { Id = emp.Id, FullName = emp.FullName };
                            context.Attach(updateEmployee);
                            updateEmployee.ImagePath = imagePath;
                        }

                        await context.SaveChangesAsync(); // Save batch updates

                        processed += employees.Count;
                        progressBar1.Value = processed;

                        lblProgress.Text = $"Processed: {processed}/{totalEmployees}";
                        lblProgress.Refresh();
                    }

                    MessageBox.Show("Processing completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Processing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CreateImage(Employee emp, string outputPath)
        {
            string imagePath = txtFolderPath.Text;
            if (emp.GenderId == 1)
            {
                imagePath += "\\male." + formate.SelectedItem.ToString();
            }
            else
            {
                if (emp.LocationId == 1) imagePath += "\\female1." + formate.SelectedItem.ToString();
                else imagePath += "\\female2." + formate.SelectedItem.ToString();
            }
            if (File.Exists(outputPath))
            {
                File.Delete(outputPath);
            }
            using (Bitmap bitmap = new Bitmap(imagePath)) // Create a blank image
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                int imageWidth = bitmap.Width;
                int imageHeight = bitmap.Height;

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Font font = new Font(selectedFontName, selectedFontSize, selectedFontStyle);
                SolidBrush brush = new SolidBrush(selectedTextColor);
                SizeF textSize = graphics.MeasureString(emp.FullName.Trim(), font);
                SizeF textSize2 = graphics.MeasureString(emp.Deprtment.Trim(), font);
                float x = (imageWidth - textSize.Width) / 2;
                float x2 = (imageWidth - textSize2.Width) / 2;

                graphics.DrawString($"{emp.FullName.Trim()}", font, brush, new PointF(x, 50));
                graphics.DrawString($"{emp.Deprtment.Trim()}", font, brush, new PointF(x2, 110));

                // Define the text to draw
                //string text = $"Name: {emp.FullName}\nDepartment: {emp.Deprtment}";

                //// Measure text size
                //SizeF textSize = graphics.MeasureString(text, font);

                //// Calculate center position
                //float x = (imageWidth - textSize.Width) / 2;
                //float y = (imageHeight - textSize.Height) / 2;

                //// Draw text in the center
                //graphics.DrawString(text, font, brush, new PointF(x, y));

                bitmap.Save(outputPath, ImageFormat.Jpeg);
            }
        }

        private void createCurrentEmp(Employee emp)
        {
            CreateImage(emp, $"{txtOutputPath.Text}\\{emp.Id}.{selectedFormate}");
            MessageBox.Show("Processing completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            string dbType = Oracle.Checked ? "Oracle" : "SQLServer";
            string connectionString = conn.Text;

            try
            {
                using (var context = new AppDbContext(dbType, connectionString))
                {
                    if (!await context.Database.CanConnectAsync())
                    {
                        MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int totalEmployees = await context.Employees.CountAsync();

                    var employees = await context.Employees
                              .AsNoTracking()
                              .OrderBy(e => e.Id)
                              .Take(totalEmployees)
                              .ToListAsync();
                    var formattedEmployees = employees
                     .Select(e => new
                     {
                         Id = e.Id,
                         DisplayText = $"{e.Id}-{e.FullName}" // Format as "Id_FullName"
                     })
                     .ToList();

                    // ✅ Bind to ComboBox
                    comboBox1.DataSource = formattedEmployees;
                    comboBox1.DisplayMember = "DisplayText"; // Show formatted text
                    comboBox1.ValueMember = "Id"; // Keep the Id as the value
                    MessageBox.Show("Load completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Processing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedTextColor = colorDialog.Color; // Save selected color
                    button4.BackColor = selectedTextColor; // Update UI
                    //lblSelectedColor.Text = $"Selected Color: {selectedTextColor.Name}";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cmbFonts.Items.Add(font.Name);
            }

            // Set default selected font
            cmbFonts.SelectedItem = selectedFontName;
            numericFontSize.Value = (decimal)selectedFontSize;
            LoadFontStyles();
        }
        private void LoadFontStyles()
        {
            chkListFontStyle.Items.Add("Bold");
            chkListFontStyle.Items.Add("Regular");
            chkListFontStyle.Items.Add("Italic");
            chkListFontStyle.Items.Add("Underline");
            chkListFontStyle.Items.Add("Strikeout");
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFontName = cmbFonts.SelectedItem.ToString();

        }



        private void numericFontSize_ValueChanged(object sender, EventArgs e)
        {
            selectedFontSize = (float)numericFontSize.Value;

        }

        private void chkListFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular; // Default style


            switch (chkListFontStyle.SelectedItem.ToString())
            {
                case "Bold":
                    fontStyle |= FontStyle.Bold;
                    break;
                case "Italic":
                    fontStyle |= FontStyle.Italic;
                    break;
                case "Underline":
                    fontStyle |= FontStyle.Underline;
                    break;
                case "Strikeout":
                    fontStyle |= FontStyle.Strikeout;
                    break;
            }


            selectedFontStyle = fontStyle;
        }

        private void formate2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFormate = chkListFontStyle.SelectedItem.ToString();
        }
    }
}
