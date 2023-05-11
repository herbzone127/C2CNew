﻿

using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace CHS_WeatherPortService
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1")]
    public partial class errorReport : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ErrorReport errorReportMsgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.tmdd.org/3/messages", Order = 0)]
        public ErrorReport errorReportMsg
        {
            get
            {
                return this.errorReportMsgField;
            }
            set
            {
                this.errorReportMsgField = value;
                this.RaisePropertyChanged("errorReportMsg");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ErrorReport : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Restrictions restrictionsField;

        private OrganizationInformation organizationinformationField;

        private OrganizationInformation organizationrequestingField;

        private string errorcodeField;

        private string errortextField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Restrictions restrictions
        {
            get
            {
                return this.restrictionsField;
            }
            set
            {
                this.restrictionsField = value;
                this.RaisePropertyChanged("restrictions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-information", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public OrganizationInformation organizationinformation
        {
            get
            {
                return this.organizationinformationField;
            }
            set
            {
                this.organizationinformationField = value;
                this.RaisePropertyChanged("organizationinformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-requesting", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public OrganizationInformation organizationrequesting
        {
            get
            {
                return this.organizationrequestingField;
            }
            set
            {
                this.organizationrequestingField = value;
                this.RaisePropertyChanged("organizationrequesting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error-code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string errorcode
        {
            get
            {
                return this.errorcodeField;
            }
            set
            {
                this.errorcodeField = value;
                this.RaisePropertyChanged("errorcode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error-text", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string errortext
        {
            get
            {
                return this.errortextField;
            }
            set
            {
                this.errortextField = value;
                this.RaisePropertyChanged("errortext");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 5)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class Restrictions : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string organizationinformationforwardingrestrictionsField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-information-forwarding-restrictions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string organizationinformationforwardingrestrictions
        {
            get
            {
                return this.organizationinformationforwardingrestrictionsField;
            }
            set
            {
                this.organizationinformationforwardingrestrictionsField = value;
                this.RaisePropertyChanged("organizationinformationforwardingrestrictions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 1)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ntcip.org/c2c-message-administration")]
    public partial class C2cMessageReceipt : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string informationalTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string informationalText
        {
            get
            {
                return this.informationalTextField;
            }
            set
            {
                this.informationalTextField = value;
                this.RaisePropertyChanged("informationalText");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ESSObservationType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pavement-data", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("subsurface-data", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("weather-data", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":pavement-data")]
        pavementdata,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":subsurface-data")]
        subsurfacedata,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":weather-data")]
        weatherdata,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ESSObservationReportDetail : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string esssensoridField;

        private DateTimeZone essobservationtimestampField;

        private ESSObservationType essobservationtypeField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-sensor-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string esssensorid
        {
            get
            {
                return this.esssensoridField;
            }
            set
            {
                this.esssensoridField = value;
                this.RaisePropertyChanged("esssensorid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-observation-timestamp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public DateTimeZone essobservationtimestamp
        {
            get
            {
                return this.essobservationtimestampField;
            }
            set
            {
                this.essobservationtimestampField = value;
                this.RaisePropertyChanged("essobservationtimestamp");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-observation-type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public ESSObservationType essobservationtype
        {
            get
            {
                return this.essobservationtypeField;
            }
            set
            {
                this.essobservationtypeField = value;
                this.RaisePropertyChanged("essobservationtype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 3)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DateTimeZone : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string dateField;

        private string timeField;

        private string offsetField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
                this.RaisePropertyChanged("date");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
                this.RaisePropertyChanged("time");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
                this.RaisePropertyChanged("offset");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 3)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.LRMS-Adopted-02-00-00")]
    public partial class Distance : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("blkDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("block", typeof(short), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("dm", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("dmDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ft", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ftDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("in", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("inDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("km", typeof(short), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("kmDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("m", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mi", typeof(short), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("miDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mm", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mmDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("yd", typeof(int), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ydDec", typeof(decimal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.LRMS-Adopted-02-00-00", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":blkDec")]
        blkDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":block")]
        block,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":dm")]
        dm,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":dmDec")]
        dmDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":ft")]
        ft,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":ftDec")]
        ftDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":in")]
        @in,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":inDec")]
        inDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":km")]
        km,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":kmDec")]
        kmDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":m")]
        m,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":mDec")]
        mDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":mi")]
        mi,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":miDec")]
        miDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":mm")]
        mm,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":mmDec")]
        mmDec,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":yd")]
        yd,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(":ydDec")]
        ydDec,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.LRMS-Adopted-02-00-00")]
    public partial class Height : object, System.ComponentModel.INotifyPropertyChanged
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altitude", typeof(Distance), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("verticalDatum", typeof(string), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("verticalLevel", typeof(sbyte), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.LRMS-Adopted-02-00-00")]
    public partial class GeoLocation : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int latitudeField;

        private int longitudeField;

        private string horizontalDatumField;

        private Height heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
                this.RaisePropertyChanged("latitude");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
                this.RaisePropertyChanged("longitude");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string horizontalDatum
        {
            get
            {
                return this.horizontalDatumField;
            }
            set
            {
                this.horizontalDatumField = value;
                this.RaisePropertyChanged("horizontalDatum");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public Height height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
                this.RaisePropertyChanged("height");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class OrganizationCenterInformation : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string centeridField;

        private string centernameField;

        private GeoLocation centerlocationField;

        private string centerdescriptionField;

        private string centertypeField;

        private ContactDetails centercontactdetailsField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string centerid
        {
            get
            {
                return this.centeridField;
            }
            set
            {
                this.centeridField = value;
                this.RaisePropertyChanged("centerid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string centername
        {
            get
            {
                return this.centernameField;
            }
            set
            {
                this.centernameField = value;
                this.RaisePropertyChanged("centername");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-location", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public GeoLocation centerlocation
        {
            get
            {
                return this.centerlocationField;
            }
            set
            {
                this.centerlocationField = value;
                this.RaisePropertyChanged("centerlocation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-description", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string centerdescription
        {
            get
            {
                return this.centerdescriptionField;
            }
            set
            {
                this.centerdescriptionField = value;
                this.RaisePropertyChanged("centerdescription");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string centertype
        {
            get
            {
                return this.centertypeField;
            }
            set
            {
                this.centertypeField = value;
                this.RaisePropertyChanged("centertype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-contact-details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public ContactDetails centercontactdetails
        {
            get
            {
                return this.centercontactdetailsField;
            }
            set
            {
                this.centercontactdetailsField = value;
                this.RaisePropertyChanged("centercontactdetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 6)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ContactDetails : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string contactidField;

        private string personnameField;

        private string persontitleField;

        private string phonenumberField;

        private string phonealternateField;

        private string mobilephonenumberField;

        private string mobilephoneidField;

        private string faxnumberField;

        private string pagernumberField;

        private string pageridField;

        private string emailaddressField;

        private string radiounitField;

        private string addressline1Field;

        private string addressline2Field;

        private string cityField;

        private string stateField;

        private string zipcodeField;

        private string countryField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string contactid
        {
            get
            {
                return this.contactidField;
            }
            set
            {
                this.contactidField = value;
                this.RaisePropertyChanged("contactid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("person-name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string personname
        {
            get
            {
                return this.personnameField;
            }
            set
            {
                this.personnameField = value;
                this.RaisePropertyChanged("personname");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("person-title", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string persontitle
        {
            get
            {
                return this.persontitleField;
            }
            set
            {
                this.persontitleField = value;
                this.RaisePropertyChanged("persontitle");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone-number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string phonenumber
        {
            get
            {
                return this.phonenumberField;
            }
            set
            {
                this.phonenumberField = value;
                this.RaisePropertyChanged("phonenumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone-alternate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string phonealternate
        {
            get
            {
                return this.phonealternateField;
            }
            set
            {
                this.phonealternateField = value;
                this.RaisePropertyChanged("phonealternate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mobile-phone-number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string mobilephonenumber
        {
            get
            {
                return this.mobilephonenumberField;
            }
            set
            {
                this.mobilephonenumberField = value;
                this.RaisePropertyChanged("mobilephonenumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mobile-phone-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string mobilephoneid
        {
            get
            {
                return this.mobilephoneidField;
            }
            set
            {
                this.mobilephoneidField = value;
                this.RaisePropertyChanged("mobilephoneid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fax-number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string faxnumber
        {
            get
            {
                return this.faxnumberField;
            }
            set
            {
                this.faxnumberField = value;
                this.RaisePropertyChanged("faxnumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pager-number", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string pagernumber
        {
            get
            {
                return this.pagernumberField;
            }
            set
            {
                this.pagernumberField = value;
                this.RaisePropertyChanged("pagernumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pager-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string pagerid
        {
            get
            {
                return this.pageridField;
            }
            set
            {
                this.pageridField = value;
                this.RaisePropertyChanged("pagerid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email-address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string emailaddress
        {
            get
            {
                return this.emailaddressField;
            }
            set
            {
                this.emailaddressField = value;
                this.RaisePropertyChanged("emailaddress");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("radio-unit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string radiounit
        {
            get
            {
                return this.radiounitField;
            }
            set
            {
                this.radiounitField = value;
                this.RaisePropertyChanged("radiounit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address-line1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string addressline1
        {
            get
            {
                return this.addressline1Field;
            }
            set
            {
                this.addressline1Field = value;
                this.RaisePropertyChanged("addressline1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address-line2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string addressline2
        {
            get
            {
                return this.addressline2Field;
            }
            set
            {
                this.addressline2Field = value;
                this.RaisePropertyChanged("addressline2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
                this.RaisePropertyChanged("state");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zip-code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string zipcode
        {
            get
            {
                return this.zipcodeField;
            }
            set
            {
                this.zipcodeField = value;
                this.RaisePropertyChanged("zipcode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 18)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class OrganizationInformation : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string organizationidField;

        private string organizationnameField;

        private string organizationlocationField;

        private string organizationfunctionField;

        private ContactDetails organizationcontactdetailsField;

        private OrganizationInformationCentercontactlist centercontactlistField;

        private DateTimeZone lastupdatetimeField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string organizationid
        {
            get
            {
                return this.organizationidField;
            }
            set
            {
                this.organizationidField = value;
                this.RaisePropertyChanged("organizationid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string organizationname
        {
            get
            {
                return this.organizationnameField;
            }
            set
            {
                this.organizationnameField = value;
                this.RaisePropertyChanged("organizationname");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-location", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string organizationlocation
        {
            get
            {
                return this.organizationlocationField;
            }
            set
            {
                this.organizationlocationField = value;
                this.RaisePropertyChanged("organizationlocation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-function", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string organizationfunction
        {
            get
            {
                return this.organizationfunctionField;
            }
            set
            {
                this.organizationfunctionField = value;
                this.RaisePropertyChanged("organizationfunction");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-contact-details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public ContactDetails organizationcontactdetails
        {
            get
            {
                return this.organizationcontactdetailsField;
            }
            set
            {
                this.organizationcontactdetailsField = value;
                this.RaisePropertyChanged("organizationcontactdetails");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-contact-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public OrganizationInformationCentercontactlist centercontactlist
        {
            get
            {
                return this.centercontactlistField;
            }
            set
            {
                this.centercontactlistField = value;
                this.RaisePropertyChanged("centercontactlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-update-time", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public DateTimeZone lastupdatetime
        {
            get
            {
                return this.lastupdatetimeField;
            }
            set
            {
                this.lastupdatetimeField = value;
                this.RaisePropertyChanged("lastupdatetime");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 7)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class OrganizationInformationCentercontactlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private OrganizationCenterInformation[] centercontactdetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center-contact-details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public OrganizationCenterInformation[] centercontactdetails
        {
            get
            {
                return this.centercontactdetailsField;
            }
            set
            {
                this.centercontactdetailsField = value;
                this.RaisePropertyChanged("centercontactdetails");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ESSObservationReport : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Restrictions restrictionsField;

        private OrganizationInformation organizationinformationField;

        private string stationidField;

        private ESSObservationReportEsssensorlist esssensorlistField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Restrictions restrictions
        {
            get
            {
                return this.restrictionsField;
            }
            set
            {
                this.restrictionsField = value;
                this.RaisePropertyChanged("restrictions");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-information", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public OrganizationInformation organizationinformation
        {
            get
            {
                return this.organizationinformationField;
            }
            set
            {
                this.organizationinformationField = value;
                this.RaisePropertyChanged("organizationinformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("station-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string stationid
        {
            get
            {
                return this.stationidField;
            }
            set
            {
                this.stationidField = value;
                this.RaisePropertyChanged("stationid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-sensor-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public ESSObservationReportEsssensorlist esssensorlist
        {
            get
            {
                return this.esssensorlistField;
            }
            set
            {
                this.esssensorlistField = value;
                this.RaisePropertyChanged("esssensorlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 4)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class ESSObservationReportEsssensorlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ESSObservationReportDetail[] esssensorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-sensor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ESSObservationReportDetail[] esssensor
        {
            get
            {
                return this.esssensorField;
            }
            set
            {
                this.esssensorField = value;
                this.RaisePropertyChanged("esssensor");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [ServiceContract]
    public interface WeatherPortType_v0p1
    {

        [OperationContract]
        getESSObservationResponse1 getESSObservation(getESSObservationRequest request);
        [OperationContract]
        string HelloMethod();
        publishESSObservationResponse publishESSObservation(ref MsgContextType msgContext, publishESSObservation publishESSObservation1);
        //    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //    System.Threading.Tasks.Task<getESSObservationResponse1> getESSObservationAsync(getESSObservationRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
    public partial class MsgContextType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string msgSolutionField;

        private string msgCorrelationIDField;

        private string msgTransactionField;

        private string msgSourceField;

        private string msgDestinationField;

        private string msgPriorityField;

        private System.DateTime msgTimestampField;

        private bool msgTimestampFieldSpecified;

        private Extension[] extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string msgSolution
        {
            get
            {
                return this.msgSolutionField;
            }
            set
            {
                this.msgSolutionField = value;
                this.RaisePropertyChanged("msgSolution");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string msgCorrelationID
        {
            get
            {
                return this.msgCorrelationIDField;
            }
            set
            {
                this.msgCorrelationIDField = value;
                this.RaisePropertyChanged("msgCorrelationID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string msgTransaction
        {
            get
            {
                return this.msgTransactionField;
            }
            set
            {
                this.msgTransactionField = value;
                this.RaisePropertyChanged("msgTransaction");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string msgSource
        {
            get
            {
                return this.msgSourceField;
            }
            set
            {
                this.msgSourceField = value;
                this.RaisePropertyChanged("msgSource");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string msgDestination
        {
            get
            {
                return this.msgDestinationField;
            }
            set
            {
                this.msgDestinationField = value;
                this.RaisePropertyChanged("msgDestination");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer", Order = 5)]
        public string msgPriority
        {
            get
            {
                return this.msgPriorityField;
            }
            set
            {
                this.msgPriorityField = value;
                this.RaisePropertyChanged("msgPriority");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public System.DateTime msgTimestamp
        {
            get
            {
                return this.msgTimestampField;
            }
            set
            {
                this.msgTimestampField = value;
                this.RaisePropertyChanged("msgTimestamp");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool msgTimestampSpecified
        {
            get
            {
                return this.msgTimestampFieldSpecified;
            }
            set
            {
                this.msgTimestampFieldSpecified = value;
                this.RaisePropertyChanged("msgTimestampSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extension", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public Extension[] extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
                this.RaisePropertyChanged("extension");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
    public partial class Extension : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1")]
    public partial class publishESSObservation : object, System.ComponentModel.INotifyPropertyChanged
    {

        private eSSObservationReportMsg eSSObservationReportMsgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.tmdd.org/3/messages", Order = 0)]
        public eSSObservationReportMsg eSSObservationReportMsg
        {
            get
            {
                return this.eSSObservationReportMsgField;
            }
            set
            {
                this.eSSObservationReportMsgField = value;
                this.RaisePropertyChanged("eSSObservationReportMsg");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class eSSObservationReportMsg : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ESSObservationReport[] essobservationreportitemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ess-observation-report-item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ESSObservationReport[] essobservationreportitem
        {
            get
            {
                return this.essobservationreportitemField;
            }
            set
            {
                this.essobservationreportitemField = value;
                this.RaisePropertyChanged("essobservationreportitem");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1")]
    public partial class publishESSObservationResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private C2cMessageReceipt c2cMessageReceiptField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.ntcip.org/c2c-message-administration", Order = 0)]
        public C2cMessageReceipt c2cMessageReceipt
        {
            get
            {
                return this.c2cMessageReceiptField;
            }
            set
            {
                this.c2cMessageReceiptField = value;
                this.RaisePropertyChanged("c2cMessageReceipt");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class publishESSObservationRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
        public MsgContextType msgContext;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1", Order = 0)]
        public publishESSObservation publishESSObservation;

        public publishESSObservationRequest()
        {
        }

        public publishESSObservationRequest(MsgContextType msgContext, publishESSObservation publishESSObservation)
        {
            this.msgContext = msgContext;
            this.publishESSObservation = publishESSObservation;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class publishESSObservationResponse1
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
        public MsgContextType msgContext;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1", Order = 0)]
        public publishESSObservationResponse publishESSObservationResponse;

        public publishESSObservationResponse1()
        {
        }

        public publishESSObservationResponse1(MsgContextType msgContext, publishESSObservationResponse publishESSObservationResponse)
        {
            this.msgContext = msgContext;
            this.publishESSObservationResponse = publishESSObservationResponse;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1")]
    public partial class getESSObservation : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DeviceInformationRequest deviceInformationRequestMsgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.tmdd.org/3/messages", Order = 0)]
        public DeviceInformationRequest deviceInformationRequestMsg
        {
            get
            {
                return this.deviceInformationRequestMsgField;
            }
            set
            {
                this.deviceInformationRequestMsgField = value;
                this.RaisePropertyChanged("deviceInformationRequestMsg");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequest : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Authentication authenticationField;

        private OrganizationInformation organizationinformationField;

        private OrganizationInformation organizationrequestingField;

        private string devicetypeField;

        private string deviceinformationtypeField;

        private DeviceInformationRequestFilter devicefilterField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Authentication authentication
        {
            get
            {
                return this.authenticationField;
            }
            set
            {
                this.authenticationField = value;
                this.RaisePropertyChanged("authentication");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-information", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public OrganizationInformation organizationinformation
        {
            get
            {
                return this.organizationinformationField;
            }
            set
            {
                this.organizationinformationField = value;
                this.RaisePropertyChanged("organizationinformation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("organization-requesting", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public OrganizationInformation organizationrequesting
        {
            get
            {
                return this.organizationrequestingField;
            }
            set
            {
                this.organizationrequestingField = value;
                this.RaisePropertyChanged("organizationrequesting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device-type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string devicetype
        {
            get
            {
                return this.devicetypeField;
            }
            set
            {
                this.devicetypeField = value;
                this.RaisePropertyChanged("devicetype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device-information-type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string deviceinformationtype
        {
            get
            {
                return this.deviceinformationtypeField;
            }
            set
            {
                this.deviceinformationtypeField = value;
                this.RaisePropertyChanged("deviceinformationtype");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device-filter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public DeviceInformationRequestFilter devicefilter
        {
            get
            {
                return this.devicefilterField;
            }
            set
            {
                this.devicefilterField = value;
                this.RaisePropertyChanged("devicefilter");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 6)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class Authentication : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string useridField;

        private string passwordField;

        private string operatoridField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("user-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string userid
        {
            get
            {
                return this.useridField;
            }
            set
            {
                this.useridField = value;
                this.RaisePropertyChanged("userid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("operator-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string operatorid
        {
            get
            {
                return this.operatoridField;
            }
            set
            {
                this.operatoridField = value;
                this.RaisePropertyChanged("operatorid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 3)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilter : object, System.ComponentModel.INotifyPropertyChanged
    {

        private DeviceInformationRequestFilterDeviceidlist deviceidlistField;

        private DeviceInformationRequestFilterNetworkidlist networkidlistField;

        private DeviceInformationRequestFilterLinkidlist linkidlistField;

        private DeviceInformationRequestFilterLinkdesignatorlist linkdesignatorlistField;

        private string linearreferenceField;

        private DeviceInformationRequestFilterSectionidlist sectionidlistField;

        private DeviceInformationRequestFilterPatternidlist patternidlistField;

        private System.Xml.XmlElement anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device-id-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public DeviceInformationRequestFilterDeviceidlist deviceidlist
        {
            get
            {
                return this.deviceidlistField;
            }
            set
            {
                this.deviceidlistField = value;
                this.RaisePropertyChanged("deviceidlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("network-id-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public DeviceInformationRequestFilterNetworkidlist networkidlist
        {
            get
            {
                return this.networkidlistField;
            }
            set
            {
                this.networkidlistField = value;
                this.RaisePropertyChanged("networkidlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link-id-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public DeviceInformationRequestFilterLinkidlist linkidlist
        {
            get
            {
                return this.linkidlistField;
            }
            set
            {
                this.linkidlistField = value;
                this.RaisePropertyChanged("linkidlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link-designator-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public DeviceInformationRequestFilterLinkdesignatorlist linkdesignatorlist
        {
            get
            {
                return this.linkdesignatorlistField;
            }
            set
            {
                this.linkdesignatorlistField = value;
                this.RaisePropertyChanged("linkdesignatorlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("linear-reference", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string linearreference
        {
            get
            {
                return this.linearreferenceField;
            }
            set
            {
                this.linearreferenceField = value;
                this.RaisePropertyChanged("linearreference");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("section-id-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public DeviceInformationRequestFilterSectionidlist sectionidlist
        {
            get
            {
                return this.sectionidlistField;
            }
            set
            {
                this.sectionidlistField = value;
                this.RaisePropertyChanged("sectionidlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pattern-id-list", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public DeviceInformationRequestFilterPatternidlist patternidlist
        {
            get
            {
                return this.patternidlistField;
            }
            set
            {
                this.patternidlistField = value;
                this.RaisePropertyChanged("patternidlist");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 7)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterDeviceidlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] deviceidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] deviceid
        {
            get
            {
                return this.deviceidField;
            }
            set
            {
                this.deviceidField = value;
                this.RaisePropertyChanged("deviceid");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterNetworkidlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] networkidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("network-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] networkid
        {
            get
            {
                return this.networkidField;
            }
            set
            {
                this.networkidField = value;
                this.RaisePropertyChanged("networkid");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterLinkidlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] linkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
                this.RaisePropertyChanged("link");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterLinkdesignatorlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] linkdesignatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link-designator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] linkdesignator
        {
            get
            {
                return this.linkdesignatorField;
            }
            set
            {
                this.linkdesignatorField = value;
                this.RaisePropertyChanged("linkdesignator");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterSectionidlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] sectionidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("section-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] sectionid
        {
            get
            {
                return this.sectionidField;
            }
            set
            {
                this.sectionidField = value;
                this.RaisePropertyChanged("sectionid");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tmdd.org/3/messages")]
    public partial class DeviceInformationRequestFilterPatternidlist : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string[] patternidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pattern-id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string[] patternid
        {
            get
            {
                return this.patternidField;
            }
            set
            {
                this.patternidField = value;
                this.RaisePropertyChanged("patternid");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1")]
    public partial class getESSObservationResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private eSSObservationReportMsg eSSObservationReportMsgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.tmdd.org/3/messages", Order = 0)]
        public eSSObservationReportMsg eSSObservationReportMsg
        {
            get
            {
                return this.eSSObservationReportMsgField;
            }
            set
            {
                this.eSSObservationReportMsgField = value;
                this.RaisePropertyChanged("eSSObservationReportMsg");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    [DataContract]
    public partial class getESSObservationRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
        public MsgContextType msgContext;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1", Order = 0)]
        public getESSObservation getESSObservation;

        public getESSObservationRequest()
        {
        }

        public getESSObservationRequest(MsgContextType msgContext, getESSObservation getESSObservation)
        {
            this.msgContext = msgContext;
         
            this.getESSObservation = getESSObservation;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    [DataContract]
    public partial class getESSObservationResponse1
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://transport.nsw.gov.au/rms")]
        public MsgContextType msgContext;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://transport.nsw.gov.au/rms/services/entity/devices/Weather_v0p1", Order = 0)]
        public getESSObservationResponse getESSObservationResponse;

        public getESSObservationResponse1()
        {
        }

        public getESSObservationResponse1(MsgContextType msgContext, getESSObservationResponse getESSObservationResponse)
        {
            this.msgContext = msgContext;
            this.getESSObservationResponse = getESSObservationResponse;
        }
    }



    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherPortType_v0p1Client : WeatherPortType_v0p1
    {

        //public WeatherPortType_v0p1Client()
        //{
        //}

        //public WeatherPortType_v0p1Client(string endpointConfigurationName) :
        //        base(endpointConfigurationName)
        //{
        //}

        //public WeatherPortType_v0p1Client(string endpointConfigurationName, string remoteAddress) :
        //        base(endpointConfigurationName, remoteAddress)
        //{
        //}

        //public WeatherPortType_v0p1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        //        base(endpointConfigurationName, remoteAddress)
        //{
        //}

        //public WeatherPortType_v0p1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        //        base(binding, remoteAddress)
        //{
        //}

        //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        //publishESSObservationResponse1 WeatherPortType_v0p1.publishESSObservation(publishESSObservationRequest request) {
        //    return base.Channel.publishESSObservation(request);
        //}

        public publishESSObservationResponse publishESSObservation(ref MsgContextType msgContext, publishESSObservation publishESSObservation1)
        {
            publishESSObservationRequest inValue = new publishESSObservationRequest();
            inValue.msgContext = msgContext;
            inValue.publishESSObservation = publishESSObservation1;
            publishESSObservationResponse1 retVal = new publishESSObservationResponse1();
            msgContext = retVal.msgContext;
            return retVal.publishESSObservationResponse;
        }

        //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        //System.Threading.Tasks.Task<publishESSObservationResponse1> WeatherPortType_v0p1.publishESSObservationAsync(publishESSObservationRequest request) {
        //    return base.Channel.publishESSObservationAsync(request);
        //}

        //public System.Threading.Tasks.Task<publishESSObservationResponse1> publishESSObservationAsync(MsgContextType msgContext, publishESSObservation publishESSObservation) {
        //    publishESSObservationRequest inValue = new publishESSObservationRequest();
        //    inValue.msgContext = msgContext;
        //    inValue.publishESSObservation = publishESSObservation;
        //    return ((WeatherPortType_v0p1)(this)).publishESSObservationAsync(inValue);
        //}

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public getESSObservationResponse1 getESSObservation(getESSObservationRequest request)
        {


            List<ESSObservationReport> eSSObservationReports = new List<ESSObservationReport>();
            if (request.getESSObservation != null)
            {
                if (request.getESSObservation.deviceInformationRequestMsg != null)
                {
                    if (request.getESSObservation.deviceInformationRequestMsg.authentication != null)
                    {
                        var auth = request.getESSObservation.deviceInformationRequestMsg.authentication;
                        if (auth.userid == "1" && auth.operatorid == "1" && auth.password == "Admin123")
                        {
                            var cert = Selfsigned.Certificates.GenerateCertificate("Test");
                            Selfsigned.Certificates.SaveCertificate(cert);
                            eSSObservationReports.Add(new ESSObservationReport
                            {
                                stationid = "test1",
                                organizationinformation = new OrganizationInformation { organizationname = "testing" }
                            }
          );
                            var response = new getESSObservationResponse1()
                            {
                                getESSObservationResponse = new getESSObservationResponse
                                {
                                    eSSObservationReportMsg = new eSSObservationReportMsg
                                    {
                                        essobservationreportitem = eSSObservationReports.ToArray()
                                    },

                                },
                            };

                            return response;
                        }
                    }
                }
            }
            return null;
        }
        public string HelloMethod()
        {
            return "Hello World";
        }
        public getESSObservationResponse getESSObservation(ref MsgContextType msgContext, getESSObservation getESSObservation1)
        {
            getESSObservationRequest inValue = new getESSObservationRequest();
            inValue.msgContext = msgContext;
            inValue.getESSObservation = getESSObservation1;
            getESSObservationResponse1 retVal = ((WeatherPortType_v0p1)(this)).getESSObservation(inValue);
            msgContext = retVal.msgContext;
            return retVal.getESSObservationResponse;
        }

        //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        //System.Threading.Tasks.Task<getESSObservationResponse1> WeatherPortType_v0p1.getESSObservationAsync(getESSObservationRequest request) {
        //    return base.Channel.getESSObservationAsync(request);
        //}

        //public System.Threading.Tasks.Task<getESSObservationResponse1> getESSObservationAsync(MsgContextType msgContext, getESSObservation getESSObservation) {
        //    getESSObservationRequest inValue = new getESSObservationRequest();
        //    inValue.msgContext = msgContext;
        //    inValue.getESSObservation = getESSObservation;
        //    return ((WeatherPortType_v0p1)(this)).getESSObservationAsync(inValue);
        //}
    }
}

