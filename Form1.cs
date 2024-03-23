namespace NtofosApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string filePath = openFileDialog1.FileName;
					string fileName = Path.GetFileName(filePath);
					string destPath = Path.Combine(@"C:\Users\acer\OneDrive\Documents\CS\NtofosApplication\Data\Songs\", fileName);

					// Copy the selected file to the specified directory
					File.Copy(filePath, destPath, true);

					MessageBox.Show($"{filePath},{fileName},{destPath}");
					// Copy the selected file to the project directory
					//File.Copy(filePath, destPath, true);

					//MessageBox.Show("File uploaded and saved successfully!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
	}
}
