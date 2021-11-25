public class TestEvent : AppEvent
{
    private string texto;

    public TestEvent(string _texto)
    {
        texto = _texto;
    }

    public string GetText()
    {
        return texto;
    }

}
