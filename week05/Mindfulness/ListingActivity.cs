using System;
using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    /*--------------------------------------------------------*/
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0)
    {

    }

    /*---------------------------------------------------*/

    public void Run()
    {

    }

    /*-----------------------------------------------*/

    public void GetRandomPrompt()
    {

    }

    /*-----------------------------------------------*/

    public List<string> GetListFromUser()
    {
        return _prompts;
    }

    /*-----------------------------------------------*/



}