
namespace ODMO.Commons.Enums
{
    public enum TradeRequestErrorEnum : int
    {
        othertransact = 30023,//Estou em outros neg�cios. N�o � poss�vel solicitar a transa��o
        inventoryfull = 11015,// nenhum espa�o vazio na minha bolsa
        otherinventoryfull = 30031 // Sem espa�o vazio na bolsa do oponente
    }
}
