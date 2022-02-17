namespace TodoForms;

/// <summary>
///  Classe che gestisce un form
/// </summary>

public partial class Form1 : Form
{
    /// <summary>
    /// Costruttore
    /// </summary>
    public Form1()
    {
        InitializeComponent();
    }


    private void BtnEvento_Click(object sender, System.EventArgs e)
    {
        //MessageBox.Show("Ho gestito l'Evento Click");

        MouseEventArgs me = (MouseEventArgs)e;
        MessageBox.Show("in event args il bottone è: " + me.Button + " Numero di click " + me.Clicks + " Location: " + me.Location);
    }

    private void Frm_Close(object sender, System.EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Vuoi veramente chiudere senza salvare", "message box di chiusura programma", MessageBoxButtons.OKCancel);
        if (dr == DialogResult.Cancel)
        {             
            ((FormClosingEventArgs)e).Cancel = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("hai cliccato sul bottone fatto con la toolbox");

        MessageBox.Show(textBox1.Text);
    }

    private void apriToolStripMenuItem_Click(object sender, EventArgs e)
    {
       DialogResult dr = folderBrowserDialog1.ShowDialog(this);

       if (dr == DialogResult.OK)
       {
           MessageBox.Show(folderBrowserDialog1.SelectedPath);
       }

    }
}
