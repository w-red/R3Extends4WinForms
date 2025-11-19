using Shouldly;
using System.Windows.Forms;
using R3Extends4WinForms;

namespace R3Extends4WinFormsTest;

public class AsObservableTest
{
    [Fact]
    public void FormLoadAsObservableTest()
    {
        var form = new Form();
        var observed = false;
        var observable = 
            form.
            LoadAsObservable();
        using var subscription =
            observable.
            Subscribe(_ => { observed = true; return Disposable.Empty; });

        form.Show();
        observed.ShouldBeTrue();
        form.Close();
    }
}