using System;
using System.Windows.Forms;
using R3;
using R3.WinForms;
using R3Extends4WinForms;

using SampleCommonModules;

namespace WinFormsSampleNet472;

/// <summary>View - Sample</summary>
public partial class R3Extends4WinFormsSample : Form
{
    /// <summary>Disposables</summary>
    protected CompositeDisposable Disposables { get; } =
        [];

    /// <summary>ViewModel</summary>
    protected R3Extends4WinFormsSampleViewModel Vm { get; } =
        new();

    /// <summary>Constructor</summary>
    public R3Extends4WinFormsSample()
    {
        InitializeComponent();

        components ??= new System.ComponentModel.Container();

        // load event as observable and subscribe.
        this.LoadAsObservable()
            .Subscribe(e =>
            {
                // setup data binding.
                OutputTb.DataBindings.Add(
                    "Text",
                    Vm.OutputText,
                    "Value",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);
                ExecuteButton.DataBindings.Add(
                    "Enabled",
                    Vm.ButtonCanExecute,
                    "Value",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged);

                // add events binding.
                ToLowerRb
                    .CheckedChangedAsObservable()
                    .Where(_ => ToLowerRb.Checked)
                    .Subscribe(_ =>
                        Vm.OperationMode.Value =
                            R3Extends4WinFormsSampleViewModel
                            .OperationModeEnum
                            .ToLower)
                    .AddTo(Disposables);
                ToUpperRb
                    .CheckedChangedAsObservable()
                    .Where(_ => ToUpperRb.Checked)
                    .Subscribe(_ =>
                        Vm.OperationMode.Value =
                            R3Extends4WinFormsSampleViewModel
                            .OperationModeEnum
                            .ToUpper)
                    .AddTo(Disposables);
                RawRb
                    .CheckedChangedAsObservable()
                    .Where(_ => RawRb.Checked)
                    .Subscribe(_ =>
                        Vm.OperationMode.Value =
                            R3Extends4WinFormsSampleViewModel
                            .OperationModeEnum
                            .Raw)
                    .AddTo(Disposables);
                DeleteRb
                    .CheckedChangedAsObservable()
                    .Where(_ => DeleteRb.Checked)
                    .Subscribe(_ =>
                        Vm.OperationMode.Value =
                            R3Extends4WinFormsSampleViewModel
                            .OperationModeEnum
                            .Delete)
                    .AddTo(Disposables);

                ExecuteButton
                    .ClickAsObservable()
                    .Subscribe(_ =>
                        Vm.ButtonCommand.Execute(new Unit()))
                    .AddTo(Disposables);

                InputTb
                    .TextChangedAsObservable()
                    .Subscribe(_ =>
                        {
                            if (InputTb.Text != Vm.InputText.Value)
                            {
                                Vm.InputText.Value = InputTb.Text;
                                Vm.ButtonCanExecute.Value =
                                    !string
                                    .IsNullOrEmpty(InputTb.Text);
                            }
                        }
                    )
                    .AddTo(Disposables);

                // output binding
                Vm.OutputText
                    .Subscribe(x =>
                        {
                            if (OutputTb.Text != x)
                            {
                                OutputTb.Text = x; 
                            }
                        }
                    )
                    .AddTo(Disposables);
            })
            .AddTo(Disposables);

        // close event as observable and subscribe.
        this.FormClosedAsObservable()
            .Subscribe(e =>
            {
                // dispose viewmodel.
                Vm.Dispose();
                // dispose own disposables.
                Disposables.Dispose();
            })
            .AddTo(Disposables);
    }
}
