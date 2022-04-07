
public static string[] Split(string nput, int lenth = 30)
{
    if (nput.Length < lenth) return new string[1] { nput };
    if (!nput.Contains(" "))
    {
        List<string> bck = new List<string>();
        bck.Add(nput.Substring(0, lenth));
        string[] nxt = Split(nput.Substring(lenth), lenth);
        foreach (string itm in nxt)
        {
            bck.Add(itm);
        }
        return bck.ToArray();

    }
    List<char> chs = nput.Substring(0, lenth).ToCharArray().ToList();
    int LastCut = lenth;

    for (int i = chs.Count - 1; i >= 0; i--)
    {
        if (chs[i] == ' ') break;
        else
        {
            chs.RemoveAt(i);
            LastCut--;
        }
    }

    if (nput.Length > lenth)
    {
        List<string> bck = new List<string>();
        bck.Add(new string(chs.ToArray()));
        string[] nxt = Split(nput.Substring(LastCut), lenth);
        foreach(string itm in nxt)
        {
            bck.Add(itm);
        }
        return bck.ToArray();
    }
    else
    {
        return new string[1] { new string(chs.ToArray()) };
    }
}
