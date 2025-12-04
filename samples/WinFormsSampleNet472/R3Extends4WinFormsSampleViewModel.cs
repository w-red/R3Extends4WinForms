using R3;
using System;

namespace WinFormsSampleNet472;

/// <summary>ViewModel - Sample</summary>
public class R3Extends4WinFormsSampleViewModel : IDisposable
{
    /// <summary>Disposables</summary>
    public CompositeDisposable Disposables { get; } = [];

    /// <summary>OperationMode</summary>
    public enum OperationModeEnum
    {
        Raw,
        ToUpper,
        ToLower,
        Delete,
    }
    /// <summary>OperationMode</summary>
    public BindableReactiveProperty<OperationModeEnum> OperationMode { get; } =
        new BindableReactiveProperty<OperationModeEnum>(
            OperationModeEnum.ToLower)
        .EnableValidation<R3Extends4WinFormsSampleViewModel>();

    /// <summary>ButtonCanExecute</summary>
    public BindableReactiveProperty<bool> ButtonCanExecute { get; } =
        new BindableReactiveProperty<bool>(false)
        .EnableValidation<R3Extends4WinFormsSampleViewModel>();

    /// <summary>InputText</summary>
    public BindableReactiveProperty<string> InputText { get; } =
        new BindableReactiveProperty<string>("")
        .EnableValidation<R3Extends4WinFormsSampleViewModel>();
    /// <summary>OutputText</summary>
    public BindableReactiveProperty<string> OutputText { get; } =
        new BindableReactiveProperty<string>("")
        .EnableValidation<R3Extends4WinFormsSampleViewModel>();

    /// <summary>ButtonCommand</summary>
    public ReactiveCommand ButtonCommand { get; }

    /// <summary>Constructor</summary>
    public R3Extends4WinFormsSampleViewModel()
    {
        ButtonCommand = ButtonCanExecute
            .ToReactiveCommand()
            .AddTo(Disposables);
        ButtonCommand
            .Subscribe(_ =>
            {
                OutputText.Value = OperationMode.Value switch
                {
                    OperationModeEnum.Raw =>
                        InputText.Value,
                    OperationModeEnum.ToUpper =>
                        InputText.Value.ToUpper(),
                    OperationModeEnum.ToLower =>
                        InputText.Value.ToLower(),
                    OperationModeEnum.Delete =>
                        string.Empty,
                    _ => "Error!"
                };
            })
            .AddTo(Disposables);
    }

    /// <summary>Dispose</summary>
    public void Dispose()
    {
        Disposables.Dispose();
    }
}
