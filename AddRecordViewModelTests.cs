using NET_MAUI_BLE.Object.View;

namespace UniteTestProject;

public class AddRecordViewModelTests
{
    [Fact]
    public void RefreshTest()
    {
        //Arrange
        var viewModel = new AddRecordViewModel();
        viewModel.FileButtonText = "Random";
        viewModel.RecordName = "Record1";
        viewModel.FilePath = "./random.wav";
        viewModel.SelectedPatient = new PatientInfo("name", "id");

        //Act
        viewModel.Refresh();

        //Assert
        viewModel.FileButtonText.Should().Be("Select a File");
        viewModel.RecordName.Should().BeEmpty();
        viewModel.FilePath.Should().BeEmpty();
        viewModel.SelectedPatient.Should().BeNull();
    }
}
