namespace LoanManagementSys;

public partial class MainForm : Form
{
    SystemManager systemmanager;

    public MainForm()
    {
        InitializeComponent();
        systemmanager = new SystemManager(this);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        //loanSystem.Start();

        systemmanager.MakeThreads();
        systemmanager.LiveThreads();

        //This code is only an example of how 
        //you can update the list boxes or other 
        //components on the GUI. Use the  code 
        //in UpdateProducts in the class where you create your 
        //tasks and threads to update the listboxes on the 
        //MainForm.
        //string[] items = { "Product 1", "Product 2", "Product 3" };
        //for (int i = 0; i < items.Length; i++)
        //{
        //    UpdateProducts(items[i], i);

        //}
        
    }
    public void UpdateEvents(string item)
    {
        if (lstItems.InvokeRequired)
        {
            lstOutput.Invoke(new Action<string>(UpdateEvents), item);
        }
        else
        { 

            lstOutput.Items.Add(item);
        }
    }


    private void btnStop_Click(object sender, EventArgs e)
    {
        //loanSystem.Stop();
        systemmanager.KillThreads();
   }


    public void UpdateProductListBox(string item)
    {
        // Check if we need to call Invoke to marshal the call to the UI thread
        if (lstItems.InvokeRequired)
        {
            lstItems.Invoke(new Action<string>(UpdateProductListBox), item);
        }
        else
        {

            lstItems.Items.Add(item);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // loanThread = null;
        // returnThread = null;
        //loanSystem.Stop();
        Application.Exit();
    }
}