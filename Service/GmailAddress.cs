namespace Service;

internal class GmailAddress: MailAddress
{
    public GmailAddress()
    {
        Content = "sdAD";
        Template = "asas";
    }

    public void Test()
    {
        MailAddress mailAddress = new MailAddress();
        //mailAddress.Template = "sfasf";
        mailAddress.Content = "dcfasdfAS";
    }
}
