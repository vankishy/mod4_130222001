// See https://aka.ms/new-console-template for more information
using static KodeBuah;
public class TestMain
{
    public static void Main(string[] args)
    {
        EnumNamaBuah listBuah = EnumNamaBuah.Alpukat;
        String kodeBuah = getKodeBuah(listBuah);
        Console.WriteLine("Buah {0} memiliki kode {1}", listBuah ,kodeBuah);

        PosisiKarakterGame pos = new PosisiKarakterGame();
        pos.actionKey(TriggerKey.w);
        pos.actionKey(TriggerKey.s);
        pos.actionKey(TriggerKey.x);
        if (pos.currentAction == Action.Berdiri)
        {
            Console.WriteLine("Posisi Standby");
        } else if (pos.currentAction == Action.Tengkurap)
        {
            Console.WriteLine("Posisi Istirahat");
        }
    }
}

public class KodeBuah
{
    public enum EnumNamaBuah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka,
    }

    public static String getKodeBuah(EnumNamaBuah kodeBuah)
    {
        String[] output = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return output[(int)kodeBuah];
    }
}

public enum Action
{
    Jongkok,
    Berdiri,
    Terbang,
    Tengkurap,
}

public enum TriggerKey
{
    w,
    x,
    s,
}

public class PosisiKarakterGame
{
    public Action currentAction;

    public PosisiKarakterGame()
    {
        this.currentAction = Action.Berdiri;
    }

    public void actionKey(TriggerKey Trigger)
    {
        switch (this.currentAction)
        {
            case Action.Berdiri:
                if (Trigger == TriggerKey.w)
                {
                    this.currentAction = Action.Terbang;
                }
                else if (Trigger == TriggerKey.s)
                {
                    this.currentAction = Action.Jongkok;
                }
                break;
            case Action.Terbang:
                if (Trigger == TriggerKey.x)
                {
                    this.currentAction = Action.Jongkok;
                }
                else if (Trigger == TriggerKey.s)
                {
                    this.currentAction = Action.Berdiri;
                    
                }
                break;
            case Action.Jongkok:
                if (Trigger == TriggerKey.w)
                {
                    this.currentAction = Action.Berdiri;
                   
                }
                else if (Trigger == TriggerKey.s)
                {
                    this.currentAction = Action.Tengkurap;
                   
                }
                break;
            case Action.Tengkurap:
                if (Trigger == TriggerKey.w)
                {
                    this.currentAction = Action.Berdiri;
                   
                }
                break;
        }
    }
}