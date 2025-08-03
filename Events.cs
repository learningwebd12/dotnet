using System;

class Button
{
    public delegate void ClickHandler();
    public event ClickHandler OnClick;

    public void Click()
    {
        Console.WriteLine("Button clicked");

        if (OnClick != null)
            OnClick();
    }
}

class Program
{
    static void HandleClick()
    {
        Console.WriteLine("Button was Handled in main Method");
    }
    public static void Main()
    {
        Button btn = new Button();
        btn.OnClick += HandleClick;
        btn.Click();
    }
}