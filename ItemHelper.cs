public class ItemHelper{
    public static Item CreateItem(string itemType)
    {
        Item result = null;
        switch (itemType)
        {
            case RamaBokovaya.XML_TYPE_NAME:
                result =  new RamaBokovaya ();
                break;
            case  KolesnayaPara.XML_TYPE_NAME:
                result = new KolesnayaPara();
                break;
            case BalkaNadressornaya.XML_TYPE_NAME:
                result = new BalkaNadressornaya();
                break;
        }

        return result;
    }

    public static void AddItemToCar(Item item, Passport car){
        if (item is BalkaNadressornaya)
        {
            car.Balki.Add((BalkaNadressornaya)item);
        }
        else if (item is RamaBokovaya)
            {
                car.RamaBokovaya.Add((RamaBokovaya)item);
            }
            else if (item is KolesnayaPara)
            {
                car.KolesnayaPara.Add((KolesnayaPara)item);
            }
    }
}