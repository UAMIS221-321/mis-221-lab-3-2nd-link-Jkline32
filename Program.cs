// main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
//end main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What is your enjoyment level?");
    return Console.ReadLine().ToLower();
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if (enjoymentLevel == "boring"){
        return "Neyland Stadium";
    }
    else if (enjoymentLevel == "average"){
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "fun"){
        return "Tiger Stadium";
    }
    else if (enjoymentLevel == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "Invalid";
    }
}

static string GetGameRecommendation(string stadium){
    if (stadium == "Neyland Stadium"){
        return "vs Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if (stadium == "Tiger Stadium"){
        return "vs Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    }
    else{
        return "Invalid";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"Stadium: {stadium}");
    System.Console.WriteLine($"Game: {game}");
}