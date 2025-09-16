

namespace ODMO.Commons.Enums.ClientEnums
{
    public enum InventorySlotTypeEnum
    {

        TabInven = 0,   // nLimit::Inven
        TabEquip,       // nLimit::Equip
        TabWarehouse,   // nLimit::Warehouse

        // Abaixo de digivice
        TabSkill,       // nLimit::Skill,	 Itens de habilidade que podem ser montados em um digital
        TabChipset,     // nLimit::Chipset,	 Itens de chipset que podem ser montados em um d�gito
        TabDigivice,    // nLimit::Digivice, Slots que podem ser montados no Digiest ==> Espa�o

        TabCashShop,    // nLimit::CashShop, Compre Armaz�m de Armazenamento de Item de Dinheiro
        TabGiftShop,    // nLimit::GiftShop, Itens armazenados por presentes ou recupera��o, etc.
        TabPCBang,      // Somente invent�rio da sala de PC

        TabShareStash,  // nLimit::ShareStash
                        // ??? inven common item tab
        TabCrossWars,   // nLimit::DigimonCrossWars, Cart�o Cross Wars?Rel�gio item

        MaxSlotType
    }
}
