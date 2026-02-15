namespace CarvingScaler.Services;

/// <summary>
/// Represents the measurement unit for dimensions
/// </summary>
public enum MeasurementUnit
{
    Inches,
    Millimeters
}

/// <summary>
/// Represents the unit mode for pattern scaling
/// </summary>
public enum UnitMode
{
    GlobalUnits,      // Single unit toggle affects all dimensions
    IndividualUnits   // Different units can be used for original and new block dimensions
}

/// <summary>
/// Scoped service for managing application state and user preferences
/// </summary>
public class AppState
{
    private MeasurementUnit _defaultMeasurementUnit = MeasurementUnit.Inches;
    private UnitMode _unitMode = UnitMode.GlobalUnits;

    public MeasurementUnit DefaultMeasurementUnit
    {
        get => _defaultMeasurementUnit;
        set
        {
            if (_defaultMeasurementUnit != value)
            {
                _defaultMeasurementUnit = value;
                OnDefaultMeasurementUnitChanged?.Invoke(value);
            }
        }
    }

    public UnitMode UnitModePreference
    {
        get => _unitMode;
        set
        {
            if (_unitMode != value)
            {
                _unitMode = value;
                OnUnitModeChanged?.Invoke(value);
            }
        }
    }

    /// <summary>
    /// Event raised when the default measurement unit changes
    /// </summary>
    public event Action<MeasurementUnit>? OnDefaultMeasurementUnitChanged;

    /// <summary>
    /// Event raised when the unit mode changes
    /// </summary>
    public event Action<UnitMode>? OnUnitModeChanged;
}
