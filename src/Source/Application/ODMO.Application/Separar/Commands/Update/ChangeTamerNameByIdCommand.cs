using ODMO.Commons.DTOs.Character;
using MediatR;

namespace ODMO.Application.Separar.Commands.Update
{
    public class ChangeTamerNameByIdCommand : IRequest<CharacterDTO>
    {
        public long CharacterId { get; set; } // Voc� pode usar um identificador para identificar o personagem a ser modificado.
        public string NewCharacterName { get; set; }

        public ChangeTamerNameByIdCommand(long characterId, string newCharacterName)
        {
            CharacterId = characterId;
            NewCharacterName = newCharacterName;
        }
    }
}
