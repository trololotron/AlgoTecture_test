// Файл сгенерирован средствами Visual Studio (правка->специальная вставка->вставить XML как классы) из файла test.xml
// Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Root
{

    private RootGlobalData globalDataField;

    private RootProductOccurence[] modelFileField;

    /// <remarks/>
    public RootGlobalData GlobalData
    {
        get
        {
            return this.globalDataField;
        }
        set
        {
            this.globalDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductOccurence", IsNullable = false)]
    public RootProductOccurence[] ModelFile
    {
        get
        {
            return this.modelFileField;
        }
        set
        {
            this.modelFileField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootGlobalData
{

    private RootGlobalDataColorTable colorTableField;

    private RootGlobalDataStyle[] styleField;

    /// <remarks/>
    public RootGlobalDataColorTable ColorTable
    {
        get
        {
            return this.colorTableField;
        }
        set
        {
            this.colorTableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Style")]
    public RootGlobalDataStyle[] Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootGlobalDataColorTable
{

    private byte sizeField;

    private string dataField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootGlobalDataStyle
{

    private byte colorIndexField;

    private decimal widthField;

    private byte transparencyField;

    private bool transparencyFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ColorIndex
    {
        get
        {
            return this.colorIndexField;
        }
        set
        {
            this.colorIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Transparency
    {
        get
        {
            return this.transparencyField;
        }
        set
        {
            this.transparencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TransparencySpecified
    {
        get
        {
            return this.transparencyFieldSpecified;
        }
        set
        {
            this.transparencyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurence
{

    private RootProductOccurencePartDefinition partDefinitionField;

    private RootProductOccurenceTransformation transformationField;

    private RootProductOccurenceAttr[] attributesField;

    private RootProductOccurenceBodyInstance[] bodyInstanceField;

    private byte idField;

    private string nameField;

    private byte behaviourField;

    private string childrenField;

    private decimal unitField;

    private bool unitFieldSpecified;

    private bool isPartField;

    private ushort styleField;

    private bool styleFieldSpecified;

    private string filePathField;

    private byte instanceRefField;

    private bool instanceRefFieldSpecified;

    /// <remarks/>
    public RootProductOccurencePartDefinition PartDefinition
    {
        get
        {
            return this.partDefinitionField;
        }
        set
        {
            this.partDefinitionField = value;
        }
    }

    /// <remarks/>
    public RootProductOccurenceTransformation Transformation
    {
        get
        {
            return this.transformationField;
        }
        set
        {
            this.transformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Attr", IsNullable = false)]
    public RootProductOccurenceAttr[] Attributes
    {
        get
        {
            return this.attributesField;
        }
        set
        {
            this.attributesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BodyInstance")]
    public RootProductOccurenceBodyInstance[] BodyInstance
    {
        get
        {
            return this.bodyInstanceField;
        }
        set
        {
            this.bodyInstanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Behaviour
    {
        get
        {
            return this.behaviourField;
        }
        set
        {
            this.behaviourField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Children
    {
        get
        {
            return this.childrenField;
        }
        set
        {
            this.childrenField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool UnitSpecified
    {
        get
        {
            return this.unitFieldSpecified;
        }
        set
        {
            this.unitFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool IsPart
    {
        get
        {
            return this.isPartField;
        }
        set
        {
            this.isPartField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool StyleSpecified
    {
        get
        {
            return this.styleFieldSpecified;
        }
        set
        {
            this.styleFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FilePath
    {
        get
        {
            return this.filePathField;
        }
        set
        {
            this.filePathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte InstanceRef
    {
        get
        {
            return this.instanceRefField;
        }
        set
        {
            this.instanceRefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InstanceRefSpecified
    {
        get
        {
            return this.instanceRefFieldSpecified;
        }
        set
        {
            this.instanceRefFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurencePartDefinition
{

    private RootProductOccurencePartDefinitionBody[] bodyField;

    private byte idField;

    private string nameField;

    private byte behaviourField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Body")]
    public RootProductOccurencePartDefinitionBody[] Body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Behaviour
    {
        get
        {
            return this.behaviourField;
        }
        set
        {
            this.behaviourField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurencePartDefinitionBody
{

    private byte idField;

    private string nameField;

    private ushort styleField;

    private byte behaviourField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Behaviour
    {
        get
        {
            return this.behaviourField;
        }
        set
        {
            this.behaviourField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurenceTransformation
{

    private string relativeTransfoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RelativeTransfo
    {
        get
        {
            return this.relativeTransfoField;
        }
        set
        {
            this.relativeTransfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurenceAttr
{

    private string nameField;

    private string typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurenceBodyInstance
{

    private RootProductOccurenceBodyInstanceTransformation transformationField;

    private byte idField;

    private string nameField;

    private byte behaviourField;

    private byte bodyRefField;

    /// <remarks/>
    public RootProductOccurenceBodyInstanceTransformation Transformation
    {
        get
        {
            return this.transformationField;
        }
        set
        {
            this.transformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Behaviour
    {
        get
        {
            return this.behaviourField;
        }
        set
        {
            this.behaviourField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte BodyRef
    {
        get
        {
            return this.bodyRefField;
        }
        set
        {
            this.bodyRefField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootProductOccurenceBodyInstanceTransformation
{

    private string relativeTransfoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RelativeTransfo
    {
        get
        {
            return this.relativeTransfoField;
        }
        set
        {
            this.relativeTransfoField = value;
        }
    }
}

