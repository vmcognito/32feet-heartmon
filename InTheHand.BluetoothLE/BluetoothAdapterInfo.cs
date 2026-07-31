namespace InTheHand.Bluetooth;

public sealed class BluetoothAdapterInfo
{
    public required string Name { get; init; }
    public required string Address { get; init; }
    public required string Alias { get; init; }
    public required bool Powered { get; init; }
}