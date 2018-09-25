﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace GLEIF.rr {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    [System.Xml.Serialization.XmlRootAttribute("RelationshipData", Namespace="http://www.gleif.org/data/schema/rr/2016", IsNullable=false)]
    public partial class RelationshipDataType {
        
        private RRHeaderType headerField;
        
        private RelationshipRecordType[] relationshipRecordsField;
        
        /// <remarks/>
        public RRHeaderType Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RelationshipRecord", IsNullable=false)]
        public RelationshipRecordType[] RelationshipRecords {
            get {
                return this.relationshipRecordsField;
            }
            set {
                this.relationshipRecordsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RRHeaderType {
        
        private System.DateTime contentDateField;
        
        private string originatorField;
        
        private FileContentEnum fileContentField;
        
        private System.DateTime deltaStartField;
        
        private bool deltaStartFieldSpecified;
        
        private string recordCountField;
        
        private HeaderNextVersionType nextVersionField;
        
        private ExtensionType extensionField;
        
        /// <remarks/>
        public System.DateTime ContentDate {
            get {
                return this.contentDateField;
            }
            set {
                this.contentDateField = value;
            }
        }
        
        /// <remarks/>
        public string Originator {
            get {
                return this.originatorField;
            }
            set {
                this.originatorField = value;
            }
        }
        
        /// <remarks/>
        public FileContentEnum FileContent {
            get {
                return this.fileContentField;
            }
            set {
                this.fileContentField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DeltaStart {
            get {
                return this.deltaStartField;
            }
            set {
                this.deltaStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeltaStartSpecified {
            get {
                return this.deltaStartFieldSpecified;
            }
            set {
                this.deltaStartFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string RecordCount {
            get {
                return this.recordCountField;
            }
            set {
                this.recordCountField = value;
            }
        }
        
        /// <remarks/>
        public HeaderNextVersionType NextVersion {
            get {
                return this.nextVersionField;
            }
            set {
                this.nextVersionField = value;
            }
        }
        
        /// <remarks/>
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum FileContentEnum {
        
        /// <remarks/>
        LOU_FULL_INTERNAL,
        
        /// <remarks/>
        LOU_DELTA_INTERNAL,
        
        /// <remarks/>
        LOU_FULL_PUBLISHED,
        
        /// <remarks/>
        LOU_DELTA_PUBLISHED,
        
        /// <remarks/>
        GLEIF_FULL_INTERNAL,
        
        /// <remarks/>
        GLEIF_DELTA_INTERNAL,
        
        /// <remarks/>
        GLEIF_FULL_PUBLISHED,
        
        /// <remarks/>
        GLEIF_DELTA_PUBLISHED,
        
        /// <remarks/>
        QUERY_RESPONSE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class HeaderNextVersionType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipRecordNextVersionType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RegistrationNextVersionType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RegistrationContainerType {
        
        private System.DateTime initialRegistrationDateField;
        
        private System.DateTime lastUpdateDateField;
        
        private RegistrationStatusEnum registrationStatusField;
        
        private System.DateTime nextRenewalDateField;
        
        private bool nextRenewalDateFieldSpecified;
        
        private string managingLOUField;
        
        private ValidationSourcesTypeEnum validationSourcesField;
        
        private ValidationDocumentsTypeEnum validationDocumentsField;
        
        private string validationReferenceField;
        
        private RegistrationNextVersionType nextVersionField;
        
        private ExtensionType extensionField;
        
        /// <remarks/>
        public System.DateTime InitialRegistrationDate {
            get {
                return this.initialRegistrationDateField;
            }
            set {
                this.initialRegistrationDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LastUpdateDate {
            get {
                return this.lastUpdateDateField;
            }
            set {
                this.lastUpdateDateField = value;
            }
        }
        
        /// <remarks/>
        public RegistrationStatusEnum RegistrationStatus {
            get {
                return this.registrationStatusField;
            }
            set {
                this.registrationStatusField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime NextRenewalDate {
            get {
                return this.nextRenewalDateField;
            }
            set {
                this.nextRenewalDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NextRenewalDateSpecified {
            get {
                return this.nextRenewalDateFieldSpecified;
            }
            set {
                this.nextRenewalDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ManagingLOU {
            get {
                return this.managingLOUField;
            }
            set {
                this.managingLOUField = value;
            }
        }
        
        /// <remarks/>
        public ValidationSourcesTypeEnum ValidationSources {
            get {
                return this.validationSourcesField;
            }
            set {
                this.validationSourcesField = value;
            }
        }
        
        /// <remarks/>
        public ValidationDocumentsTypeEnum ValidationDocuments {
            get {
                return this.validationDocumentsField;
            }
            set {
                this.validationDocumentsField = value;
            }
        }
        
        /// <remarks/>
        public string ValidationReference {
            get {
                return this.validationReferenceField;
            }
            set {
                this.validationReferenceField = value;
            }
        }
        
        /// <remarks/>
        public RegistrationNextVersionType NextVersion {
            get {
                return this.nextVersionField;
            }
            set {
                this.nextVersionField = value;
            }
        }
        
        /// <remarks/>
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum RegistrationStatusEnum {
        
        /// <remarks/>
        PENDING_VALIDATION,
        
        /// <remarks/>
        PUBLISHED,
        
        /// <remarks/>
        DUPLICATE,
        
        /// <remarks/>
        LAPSED,
        
        /// <remarks/>
        RETIRED,
        
        /// <remarks/>
        ANNULLED,
        
        /// <remarks/>
        TRANSFERRED,
        
        /// <remarks/>
        PENDING_TRANSFER,
        
        /// <remarks/>
        PENDING_ARCHIVAL,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum ValidationSourcesTypeEnum {
        
        /// <remarks/>
        PENDING,
        
        /// <remarks/>
        ENTITY_SUPPLIED_ONLY,
        
        /// <remarks/>
        PARTIALLY_CORROBORATED,
        
        /// <remarks/>
        FULLY_CORROBORATED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum ValidationDocumentsTypeEnum {
        
        /// <remarks/>
        ACCOUNTS_FILING,
        
        /// <remarks/>
        REGULATORY_FILING,
        
        /// <remarks/>
        SUPPORTING_DOCUMENTS,
        
        /// <remarks/>
        CONTRACTS,
        
        /// <remarks/>
        OTHER_OFFICIAL_DOCUMENTS,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class ExtensionType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipNextVersionType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipQuantifierType {
        
        private MeasurementMethodTypeEnum measurementMethodField;
        
        private decimal quantifierAmountField;
        
        private QuantifierUnitsTypeEnum quantifierUnitsField;
        
        private bool quantifierUnitsFieldSpecified;
        
        /// <remarks/>
        public MeasurementMethodTypeEnum MeasurementMethod {
            get {
                return this.measurementMethodField;
            }
            set {
                this.measurementMethodField = value;
            }
        }
        
        /// <remarks/>
        public decimal QuantifierAmount {
            get {
                return this.quantifierAmountField;
            }
            set {
                this.quantifierAmountField = value;
            }
        }
        
        /// <remarks/>
        public QuantifierUnitsTypeEnum QuantifierUnits {
            get {
                return this.quantifierUnitsField;
            }
            set {
                this.quantifierUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantifierUnitsSpecified {
            get {
                return this.quantifierUnitsFieldSpecified;
            }
            set {
                this.quantifierUnitsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum MeasurementMethodTypeEnum {
        
        /// <remarks/>
        ACCOUNTING_CONSOLIDATION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum QuantifierUnitsTypeEnum {
        
        /// <remarks/>
        PERCENTAGE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipQualifierType {
        
        private QualifierDimensionEnum qualifierDimensionField;
        
        private QualifierCategoryTypeEnum qualifierCategoryField;
        
        private bool qualifierCategoryFieldSpecified;
        
        /// <remarks/>
        public QualifierDimensionEnum QualifierDimension {
            get {
                return this.qualifierDimensionField;
            }
            set {
                this.qualifierDimensionField = value;
            }
        }
        
        /// <remarks/>
        public QualifierCategoryTypeEnum QualifierCategory {
            get {
                return this.qualifierCategoryField;
            }
            set {
                this.qualifierCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifierCategorySpecified {
            get {
                return this.qualifierCategoryFieldSpecified;
            }
            set {
                this.qualifierCategoryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum QualifierDimensionEnum {
        
        /// <remarks/>
        ACCOUNTING_STANDARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum QualifierCategoryTypeEnum {
        
        /// <remarks/>
        US_GAAP,
        
        /// <remarks/>
        IFRS,
        
        /// <remarks/>
        OTHER_ACCOUNTING_STANDARD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipPeriodType {
        
        private System.DateTime startDateField;
        
        private bool startDateFieldSpecified;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        private PeriodTypeEnum periodTypeField;
        
        /// <remarks/>
        public System.DateTime StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EndDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PeriodTypeEnum PeriodType {
            get {
                return this.periodTypeField;
            }
            set {
                this.periodTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum PeriodTypeEnum {
        
        /// <remarks/>
        ACCOUNTING_PERIOD,
        
        /// <remarks/>
        RELATIONSHIP_PERIOD,
        
        /// <remarks/>
        DOCUMENT_FILING_PERIOD,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class NodeType {
        
        private string nodeIDField;
        
        private NodeIDTypeEnum nodeIDTypeField;
        
        /// <remarks/>
        public string NodeID {
            get {
                return this.nodeIDField;
            }
            set {
                this.nodeIDField = value;
            }
        }
        
        /// <remarks/>
        public NodeIDTypeEnum NodeIDType {
            get {
                return this.nodeIDTypeField;
            }
            set {
                this.nodeIDTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum NodeIDTypeEnum {
        
        /// <remarks/>
        LEI,
        
        /// <remarks/>
        ISO_17442_COMPATIBLE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipContainerType {
        
        private NodeType startNodeField;
        
        private NodeType endNodeField;
        
        private RelationshipTypeEnum relationshipTypeField;
        
        private RelationshipPeriodType[] relationshipPeriodsField;
        
        private RelationshipStatusEnum relationshipStatusField;
        
        private RelationshipQualifierType[][] relationshipQualifiersField;
        
        private RelationshipQuantifierType[][] relationshipQuantifiersField;
        
        private RelationshipNextVersionType nextVersionField;
        
        private ExtensionType extensionField;
        
        /// <remarks/>
        public NodeType StartNode {
            get {
                return this.startNodeField;
            }
            set {
                this.startNodeField = value;
            }
        }
        
        /// <remarks/>
        public NodeType EndNode {
            get {
                return this.endNodeField;
            }
            set {
                this.endNodeField = value;
            }
        }
        
        /// <remarks/>
        public RelationshipTypeEnum RelationshipType {
            get {
                return this.relationshipTypeField;
            }
            set {
                this.relationshipTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RelationshipPeriod", IsNullable=false)]
        public RelationshipPeriodType[] RelationshipPeriods {
            get {
                return this.relationshipPeriodsField;
            }
            set {
                this.relationshipPeriodsField = value;
            }
        }
        
        /// <remarks/>
        public RelationshipStatusEnum RelationshipStatus {
            get {
                return this.relationshipStatusField;
            }
            set {
                this.relationshipStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RelationshipQualifier", typeof(RelationshipQualifierType), IsNullable=false)]
        public RelationshipQualifierType[][] RelationshipQualifiers {
            get {
                return this.relationshipQualifiersField;
            }
            set {
                this.relationshipQualifiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RelationshipQuantifier", typeof(RelationshipQuantifierType), IsNullable=false)]
        public RelationshipQuantifierType[][] RelationshipQuantifiers {
            get {
                return this.relationshipQuantifiersField;
            }
            set {
                this.relationshipQuantifiersField = value;
            }
        }
        
        /// <remarks/>
        public RelationshipNextVersionType NextVersion {
            get {
                return this.nextVersionField;
            }
            set {
                this.nextVersionField = value;
            }
        }
        
        /// <remarks/>
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum RelationshipTypeEnum {
        
        /// <remarks/>
        IS_DIRECTLY_CONSOLIDATED_BY,
        
        /// <remarks/>
        IS_ULTIMATELY_CONSOLIDATED_BY,
        
        /// <remarks/>
        IS_INTERNATIONAL_BRANCH_OF,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public enum RelationshipStatusEnum {
        
        /// <remarks/>
        ACTIVE,
        
        /// <remarks/>
        INACTIVE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gleif.org/data/schema/rr/2016")]
    public partial class RelationshipRecordType {
        
        private RelationshipContainerType relationshipField;
        
        private RegistrationContainerType registrationField;
        
        private RelationshipRecordNextVersionType nextVersionField;
        
        private ExtensionType extensionField;
        
        /// <remarks/>
        public RelationshipContainerType Relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        public RegistrationContainerType Registration {
            get {
                return this.registrationField;
            }
            set {
                this.registrationField = value;
            }
        }
        
        /// <remarks/>
        public RelationshipRecordNextVersionType NextVersion {
            get {
                return this.nextVersionField;
            }
            set {
                this.nextVersionField = value;
            }
        }
        
        /// <remarks/>
        public ExtensionType Extension {
            get {
                return this.extensionField;
            }
            set {
                this.extensionField = value;
            }
        }
    }
}
