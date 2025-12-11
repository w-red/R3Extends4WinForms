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

    [Fact]
    public void FormLoadAsObservableOnlyFiresOnceTest()
    {
        // Arrange
        var form = new Form();
        var loadCount = 0;
        var observable = 
            form
            .LoadAsObservable();
        using var subscription = 
            observable
            .Subscribe(_ => loadCount++);

        // Act
        form.Show();
        form.Hide();
        form.Show(); // Load event only fires on first show

        // Assert
        loadCount.ShouldBe(1); // Load event fires only once
        form.Close();
    }

    [Fact]
    public void FormLoadAsObservableWithMultipleSubscriptionsTest()
    {
        // Arrange
        var form = new Form();
        var count1 = 0;
        var count2 = 0;
        var observable = 
            form
            .LoadAsObservable();
        
        using var subscription1 = 
            observable
            .Subscribe(_ => count1++);
        using var subscription2 = 
            observable
            .Subscribe(_ => count2++);

        // Act
        form.Show();

        // Assert
        count1.ShouldBe(1);
        count2.ShouldBe(1);
        form.Close();
    }

    [Fact]
    public void FormLoadAsObservableDisposeStopsObservingTest()
    {
        // Arrange
        var form = new Form();
        var loadCount = 0;
        var observable = 
            form
            .LoadAsObservable();
        var subscription = 
            observable
            .Subscribe(_ => loadCount++);

        // Act
        form.Show();
        loadCount.ShouldBe(1);
        form.Hide();

        subscription.Dispose();
        form.Show();

        // Assert
        loadCount.ShouldBe(1); // Should still be 1, not 2
        form.Close();
    }

    [Fact]
    public void FormLoadAsObservableWithEventArgsTest()
    {
        // Arrange
        var form = new Form();
        EventArgs? receivedArgs = null;
        var observable = 
            form
            .LoadAsObservable();
        using var subscription = 
            observable
            .Subscribe(args => receivedArgs = args);

        // Act
        form.Show();

        // Assert
        receivedArgs.ShouldNotBeNull();
        receivedArgs.ShouldBeOfType<EventArgs>();
        form.Close();
    }

    [Fact]
    public void FormLoadAsObservableMultipleFormsTest()
    {
        // Arrange
        var form1 = new Form();
        var form2 = new Form();
        var form1LoadCount = 0;
        var form2LoadCount = 0;
        
        var observable1 = 
            form1
            .LoadAsObservable();
        var observable2 = 
            form2
            .LoadAsObservable();
        
        using var subscription1 = 
            observable1
            .Subscribe(_ => form1LoadCount++);
        using var subscription2 = 
            observable2
            .Subscribe(_ => form2LoadCount++);

        // Act
        form1.Show();
        form2.Show();

        // Assert
        form1LoadCount.ShouldBe(1);
        form2LoadCount.ShouldBe(1);
        
        form1.Close();
        form2.Close();
    }

    [Fact]
    public void FormLoadAsObservableNoSubscriptionTest()
    {
        // Arrange & Act
        var form = new Form();
        var observable = 
            form
            .LoadAsObservable();
        
        // Show form without subscription should not throw
        form.Show();
        
        // Assert
        form.Visible.ShouldBeTrue();
        form.Close();
    }

    [Fact]
    public void FormLoadAsObservableSubscribeBeforeFirstShowTest()
    {
        // Arrange
        var form = new Form();
        var loadCount = 0;
        var observable = 
            form
            .LoadAsObservable();

        // Act - Subscribe before first show
        using var subscription = 
            observable
            .Subscribe(_ => loadCount++);
        form.Show(); // First show triggers Load event
        form.Hide();
        form.Show(); // Second show does NOT trigger Load event

        // Assert
        loadCount.ShouldBe(1); // Load event fires only on first show
        form.Close();
    }
}

