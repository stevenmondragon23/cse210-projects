using System;

class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    /*--------------------------------------------------*/

    public string GetTextBookSection()
    {
        return _textbookSection;
    }


    public void SetTextBookSection(string textBookSection)
    {
        _textbookSection = textBookSection;
    }

    /*-----------------------------------------------------------*/

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    /*-----------------------------------------------------------------*/

    public string GetHomeworkList()
    {
        return $"{_textbookSection} ---->  {_problems}";
    }

    /*-----------------------------------------------------------------------*/
}
    

