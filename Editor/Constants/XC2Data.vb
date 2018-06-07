''' <summary>
''' Information required to read an XC2 save file.
''' </summary>
Public Class XC2Data
    Public Shared PlayerInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.Halos, New HexDataInfo With {.Offset = &HEF64, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Compound_Green, New HexDataInfo With {.Offset = &HEF7C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Compound_Yellow, New HexDataInfo With {.Offset = &HEF78, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Compound_Red, New HexDataInfo With {.Offset = &HEF80, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Green_Herb, New HexDataInfo With {.Offset = &HEF84, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Green_Herb, New HexDataInfo With {.Offset = &HEF88, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Purple_Magic, New HexDataInfo With {.Offset = &HEF8C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Purple_Magic, New HexDataInfo With {.Offset = &HEF90, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Bloody_Rose, New HexDataInfo With {.Offset = &HEF94, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Bloody_Rose, New HexDataInfo With {.Offset = &HEF98, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Yellow_Moon, New HexDataInfo With {.Offset = &HEF9C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Yellow_Moon, New HexDataInfo With {.Offset = &HEFA0, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Broken_Heart, New HexDataInfo With {.Offset = &HEFA4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Broken_Pearl, New HexDataInfo With {.Offset = &HEFA8, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Arcade_Bullet, New HexDataInfo With {.Offset = &HEFAC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Red_Hot_Shot, New HexDataInfo With {.Offset = &HEFB0, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Magic_Flute, New HexDataInfo With {.Offset = &HEFB4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
        }
    ''{XC2DataType.Compound_Red, New HexDataInfo With {.Offset = &HF577, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Compound_Yellow, New HexDataInfo With {.Offset = &H4164, .Size = &H2, .ToSaveFileValue = FieldConversions.FromCoreDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
    ''{XC2DataType.Compound_Yellow, New HexDataInfo With {.Offset = &HEF56, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Compound_Green, New HexDataInfo With {.Offset = &HEF5A, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Compound_Red, New HexDataInfo With {.Offset = &HEF64, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Green_Herb, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Mega_Green, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Purple_Magic, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Mega_Purple, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Bloody_Rose, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Mega_Bloody, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Yellow_Moon, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Mega_Yellow, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Broken_Heart, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Broken_Pearl, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Arcade_Bullet, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Red_Hot_Shot, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
    ''{XC2DataType.Magic_Flute, New HexDataInfo With {.Offset = &HEF68, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
    ''}



End Class
