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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd", IsNullable=false)]
    public partial class ProviderAndRequirementMeta {
        
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
        
        private OperationSignatureType[] behaviorsField;
        
        private DomainModelType domainModelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationSignature", IsNullable=false)]
        public OperationSignatureType[] Behaviors {
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
    public partial class OperationSignatureType {
        
        private VariableType[] parameterField;
        
        private VariableType returnValueField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public VariableType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        public VariableType ReturnValue {
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class VariableType {
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        private string logicalDatatypeField;
        
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class ValidationOperationSignatureType {
        
        private VariableType[] parameterField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public VariableType[] Parameter {
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/ProviderAndRequirement_v1_0.xsd")]
    public partial class ClassModelType {
        
        private VariableType propertyField;
        
        private string nameField;
        
        private string logicalNamespaceField;
        
        /// <remarks/>
        public VariableType Property {
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
