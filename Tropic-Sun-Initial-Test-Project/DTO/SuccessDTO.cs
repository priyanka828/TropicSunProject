namespace Tropic_Sun_Initial_Test_Project.DTO;

public class SuccessDTO
{
    public bool isSuccess { get; set; }

    public SuccessDTO(bool value)
    {
        this.isSuccess = value;
    }
}