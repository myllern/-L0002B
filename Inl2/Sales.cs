static class Sales
{
    public static string getSaleLevelInfo(int level)
    {
        string sales = "";

        switch (level)
        {
            case 1:
                sales = "under 50";
                break;

            case 2:
                sales = "50-99 artiklar";
                break;

            case 3:
                sales = "100-199";
                break;

            case 4:
                sales = "över 199";
                break;
        }
        //return ($"{nrOnLevel} säljare har nått nivå {level}: {sales} artiklar");
        return "hi";
    }



    //TODO läsa från fil hur många som är i resp nivå

    public static int nrOnLevel()
    {
        return 2;
    }

}