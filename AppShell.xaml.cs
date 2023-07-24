namespace diary;

public partial class AppShell : Shell
{
    public enum PageName
    {
        List, Edit
    }
    public AppShell()
    {
        InitializeComponent();
        RegisterPage();
    }

    private void RegisterPage()
    {
        Routing.RegisterRoute(PageName.List.ToString(), typeof(ListPage));
        Routing.RegisterRoute(PageName.Edit.ToString(), typeof(EditPage));
    }
}
