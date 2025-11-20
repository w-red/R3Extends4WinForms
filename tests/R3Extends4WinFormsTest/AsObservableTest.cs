using R3;
using R3Extends4WinForms;
using Shouldly;

namespace R3Extends4WinFormsTest;

/// <summary>AsObservable's test.</summary>
public class AsObservableTest
{
    [Fact]
    public void FormLoadAsObservableTest()
    {
        // Arrange
        var form = new Form();
        var observed = false;
        var observable = 
            form.
            LoadAsObservable();
        using var subscription =
            observable.
            Subscribe(_ => observed = true);

        // Act & Assert
        form.Show();
        observed.ShouldBeTrue();
        form.Close();
    }
}