using ODMO.Commons.DTOs.Character;
using MediatR;

namespace ODMO.Application.Separar.Commands.Update
{
    public class ChangeTamerIdTPCommand : IRequest<CharacterDTO>
    {
        public long CharacterId { get; set; } // Voc� pode usar um identificador para identificar o personagem a ser modificado.
        public int NewTargetTamerIdTP { get; set; }

        public ChangeTamerIdTPCommand(long characterId, int newCharacterName)
        {
            CharacterId = characterId;
            NewTargetTamerIdTP = newCharacterName;
        }
    }
}
