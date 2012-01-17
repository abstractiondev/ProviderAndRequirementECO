//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace ProviderAndRequirement_v1_0 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("ProviderAndRequirementMeta", Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd", IsNullable=false)]
    public partial class ProviderAndRequirementMetaType {
        
        private ContractType providesField;
        
        private ContractType requiresField;
        
        /// <remarks/>
        public ContractType Provides {
            get {
                return this.providesField;
            }
            set {
                this.providesField = value;
            }
        }
        
        /// <remarks/>
        public ContractType Requires {
            get {
                return this.requiresField;
            }
            set {
                this.requiresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class ContractType {
        
        private LogicalOperationSignatureType[] behaviorsField;
        
        private DomainModelType domainModelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationSignature", IsNullable=false)]
        public LogicalOperationSignatureType[] Behaviors {
            get {
                return this.behaviorsField;
            }
            set {
                this.behaviorsField = value;
            }
        }
        
        /// <remarks/>
        public DomainModelType DomainModel {
            get {
                return this.domainModelField;
            }
            set {
                this.domainModelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class LogicalOperationSignatureType {
        
        private LogicalInformationType[] parameterField;
        
        private LogicalInformationType returnValueField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        private byte[] sha1HashField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public LogicalInformationType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        public LogicalInformationType ReturnValue {
            get {
                return this.returnValueField;
            }
            set {
                this.returnValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logicalNamespace {
            get {
                return this.logicalNamespaceField;
            }
            set {
                this.logicalNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
        public byte[] sha1Hash {
            get {
                return this.sha1HashField;
            }
            set {
                this.sha1HashField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class LogicalInformationType {
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        private string logicalDatatypeField;
        
        private byte[] sha1HashField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logicalNamespace {
            get {
                return this.logicalNamespaceField;
            }
            set {
                this.logicalNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logicalDatatype {
            get {
                return this.logicalDatatypeField;
            }
            set {
                this.logicalDatatypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
        public byte[] sha1Hash {
            get {
                return this.sha1HashField;
            }
            set {
                this.sha1HashField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class ValidationOperationSignatureType {
        
        private LogicalInformationType[] parameterField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        private byte[] sha1HashField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public LogicalInformationType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logicalNamespace {
            get {
                return this.logicalNamespaceField;
            }
            set {
                this.logicalNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
        public byte[] sha1Hash {
            get {
                return this.sha1HashField;
            }
            set {
                this.sha1HashField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class ClassModelType {
        
        private LogicalInformationType[] propertyField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        private byte[] sha1HashField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public LogicalInformationType[] Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logicalNamespace {
            get {
                return this.logicalNamespaceField;
            }
            set {
                this.logicalNamespaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="hexBinary")]
        public byte[] sha1Hash {
            get {
                return this.sha1HashField;
            }
            set {
                this.sha1HashField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class DomainModelType {
        
        private ClassModelType[] classesField;
        
        private ValidationOperationSignatureType[] validationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ClassModel", IsNullable=false)]
        public ClassModelType[] Classes {
            get {
                return this.classesField;
            }
            set {
                this.classesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidationOperationSignature", IsNullable=false)]
        public ValidationOperationSignatureType[] Validations {
            get {
                return this.validationsField;
            }
            set {
                this.validationsField = value;
            }
        }
    }
}
