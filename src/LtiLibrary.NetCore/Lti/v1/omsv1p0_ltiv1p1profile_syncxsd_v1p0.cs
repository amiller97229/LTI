﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

using System.Xml.Serialization;

namespace LtiLibrary.NetCore.Lti.v1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [XmlType(TypeName = "imsx_CodeMajor.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_codeMajor", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public enum imsx_CodeMajorType
    {

        /// <remarks/>
        success,

        /// <remarks/>
        processing,

        /// <remarks/>
        failure,

        /// <remarks/>
        unsupported,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [XmlType(TypeName = "imsx_Severity.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_severity", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public enum imsx_SeverityType
    {

        /// <remarks/>
        status,

        /// <remarks/>
        warning,

        /// <remarks/>
        error,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [XmlType(TypeName = "imsx_CodeMinorValue.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_codeMinorFieldValue", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public enum imsx_CodeMinorValueType
    {

        /// <remarks/>
        fullsuccess,

        /// <remarks/>
        createsuccess,

        /// <remarks/>
        nosourcedids,

        /// <remarks/>
        idallocfail,

        /// <remarks/>
        overflowfail,

        /// <remarks/>
        idallocinusefail,

        /// <remarks/>
        invaliddata,

        /// <remarks/>
        incompletedata,

        /// <remarks/>
        partialdatastorage,

        /// <remarks/>
        unknownobject,

        /// <remarks/>
        unknownquery,

        /// <remarks/>
        deletefailure,

        /// <remarks/>
        targetreadfailure,

        /// <remarks/>
        savepointerror,

        /// <remarks/>
        savepointsyncerror,

        /// <remarks/>
        toomuchdata,

        /// <remarks/>
        unsupportedlineitemtype,

        /// <remarks/>
        unknowncontext,

        /// <remarks/>
        unauthorizedresultreplace,

        /// <remarks/>
        unknownperson,

        /// <remarks/>
        gradingnotpermitted,

        /// <remarks/>
        invalidresult,

        /// <remarks/>
        resultalreadyposted,

        /// <remarks/>
        unknownextension,

        /// <remarks/>
        unknownvocabulary,

        /// <remarks/>
        unknownmdvocabulary,

        /// <remarks/>
        targetisbusy,

        /// <remarks/>
        linkfailure,

        /// <remarks/>
        unauthorizedrequest,

        /// <remarks/>
        unsupportedLIS,

        /// <remarks/>
        unsupportedLISoperation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [XmlType(TypeName = "imsx_GWSVersionValue.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_version", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public enum imsx_GWSVersionValueType
    {

        /// <remarks/>
        [XmlEnum("V1.0")]
        V10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_CodeMinor.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_codeMinor", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_CodeMinorType
    {

        private imsx_CodeMinorFieldType[] imsx_codeMinorFieldField;

        /// <remarks/>
        [XmlElement("imsx_codeMinorField")]
        public imsx_CodeMinorFieldType[] imsx_codeMinorField
        {
            get
            {
                return this.imsx_codeMinorFieldField;
            }
            set
            {
                this.imsx_codeMinorFieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_CodeMinorField.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_codeMinorField", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_CodeMinorFieldType
    {

        private string imsx_codeMinorFieldNameField;

        private imsx_CodeMinorValueType imsx_codeMinorFieldValueField;

        /// <remarks/>
        public imsx_CodeMinorFieldType()
        {
            this.imsx_codeMinorFieldNameField = "TargetEndSystem";
        }

        /// <remarks/>
        public string imsx_codeMinorFieldName
        {
            get
            {
                return this.imsx_codeMinorFieldNameField;
            }
            set
            {
                this.imsx_codeMinorFieldNameField = value;
            }
        }

        /// <remarks/>
        public imsx_CodeMinorValueType imsx_codeMinorFieldValue
        {
            get
            {
                return this.imsx_codeMinorFieldValueField;
            }
            set
            {
                this.imsx_codeMinorFieldValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_StatusInfo.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_statusInfo", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_StatusInfoType
    {

        private imsx_CodeMajorType imsx_codeMajorField;

        private imsx_SeverityType imsx_severityField;

        private string imsx_descriptionField;

        private string imsx_messageRefIdentifierField;

        private string[] imsx_operationRefIdentifierField;

        private imsx_CodeMinorFieldType[] imsx_codeMinorField;

        /// <remarks/>
        public imsx_CodeMajorType imsx_codeMajor
        {
            get
            {
                return this.imsx_codeMajorField;
            }
            set
            {
                this.imsx_codeMajorField = value;
            }
        }

        /// <remarks/>
        public imsx_SeverityType imsx_severity
        {
            get
            {
                return this.imsx_severityField;
            }
            set
            {
                this.imsx_severityField = value;
            }
        }

        /// <remarks/>
        public string imsx_description
        {
            get
            {
                return this.imsx_descriptionField;
            }
            set
            {
                this.imsx_descriptionField = value;
            }
        }

        /// <remarks/>
        public string imsx_messageRefIdentifier
        {
            get
            {
                return this.imsx_messageRefIdentifierField;
            }
            set
            {
                this.imsx_messageRefIdentifierField = value;
            }
        }

        /// <remarks/>
        [XmlElement("imsx_operationRefIdentifier")]
        public string[] imsx_operationRefIdentifier
        {
            get
            {
                return this.imsx_operationRefIdentifierField;
            }
            set
            {
                this.imsx_operationRefIdentifierField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("imsx_codeMinorField", IsNullable = false)]
        public imsx_CodeMinorFieldType[] imsx_codeMinor
        {
            get
            {
                return this.imsx_codeMinorField;
            }
            set
            {
                this.imsx_codeMinorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "Result.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("result", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class ResultType
    {

        private TextType resultScoreField;
        private LtiReponseType resultDataField;

        /// <remarks/>
        public TextType resultScore
        {
            get
            {
                return this.resultScoreField;
            }
            set
            {
                this.resultScoreField = value;
            }
        }

        /// <remarks/>
        public LtiReponseType resultData
        {
            get
            {
                return this.resultDataField;
            }
            set
            {
                this.resultDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "Text.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("resultScore", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class TextType
    {

        private string languageField;

        private string textStringField;

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string textString
        {
            get
            {
                return this.textStringField;
            }
            set
            {
                this.textStringField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[XmlType(TypeName = "Text.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("resultScore", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class LtiReponseType
    {

        private string ltiLaunchUrlField;

        /// <remarks/>
        public string ltiLaunchUrl
        {
            get
            {
                return this.ltiLaunchUrlField;
            }
            set
            {
                this.ltiLaunchUrlField = value;
            }
        }


    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "SourcedGUID.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("sourcedGUID", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class SourcedGUIDType
    {

        private string refAgentInstanceIDField;

        private string sourcedIdField;

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string refAgentInstanceID
        {
            get
            {
                return this.refAgentInstanceIDField;
            }
            set
            {
                this.refAgentInstanceIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string sourcedId
        {
            get
            {
                return this.sourcedIdField;
            }
            set
            {
                this.sourcedIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "ResultRecord.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("resultRecord", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class ResultRecordType
    {

        private SourcedGUIDType sourcedGUIDField;

        private ResultType resultField;

        /// <remarks/>
        public SourcedGUIDType sourcedGUID
        {
            get
            {
                return this.sourcedGUIDField;
            }
            set
            {
                this.sourcedGUIDField = value;
            }
        }

        /// <remarks/>
        public ResultType result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class deleteResultRequest
    {

        private ResultRecordType resultRecordField;

        /// <remarks/>
        public ResultRecordType resultRecord
        {
            get
            {
                return this.resultRecordField;
            }
            set
            {
                this.resultRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class deleteResultResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class readResultRequest
    {

        private ResultRecordType resultRecordField;

        /// <remarks/>
        public ResultRecordType resultRecord
        {
            get
            {
                return this.resultRecordField;
            }
            set
            {
                this.resultRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class readResultResponse
    {

        private ResultType resultField;

        /// <remarks/>
        public ResultType result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class replaceResultRequest
    {

        private ResultRecordType resultRecordField;

        /// <remarks/>
        public ResultRecordType resultRecord
        {
            get
            {
                return this.resultRecordField;
            }
            set
            {
                this.resultRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot(Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class replaceResultResponse
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_POXBody.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_POXBody", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_POXBodyType
    {

        private object itemField;

        /// <remarks/>
        [XmlElement("deleteResultRequest", typeof(deleteResultRequest))]
        [XmlElement("deleteResultResponse", typeof(deleteResultResponse))]
        [XmlElement("readResultRequest", typeof(readResultRequest))]
        [XmlElement("readResultResponse", typeof(readResultResponse))]
        [XmlElement("replaceResultRequest", typeof(replaceResultRequest))]
        [XmlElement("replaceResultResponse", typeof(replaceResultResponse))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_POXHeader.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_POXHeader", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_POXHeaderType
    {

        private object itemField;

        /// <remarks/>
        [XmlElement("imsx_POXRequestHeaderInfo", typeof(imsx_RequestHeaderInfoType))]
        [XmlElement("imsx_POXResponseHeaderInfo", typeof(imsx_ResponseHeaderInfoType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_RequestHeaderInfo.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_POXRequestHeaderInfo", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_RequestHeaderInfoType
    {

        private imsx_GWSVersionValueType imsx_versionField;

        private string imsx_messageIdentifierField;

        private string imsx_sendingAgentIdentifierField;

        /// <remarks/>
        public imsx_GWSVersionValueType imsx_version
        {
            get
            {
                return this.imsx_versionField;
            }
            set
            {
                this.imsx_versionField = value;
            }
        }

        /// <remarks/>
        public string imsx_messageIdentifier
        {
            get
            {
                return this.imsx_messageIdentifierField;
            }
            set
            {
                this.imsx_messageIdentifierField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string imsx_sendingAgentIdentifier
        {
            get
            {
                return this.imsx_sendingAgentIdentifierField;
            }
            set
            {
                this.imsx_sendingAgentIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_ResponseHeaderInfo.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_POXResponseHeaderInfo", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_ResponseHeaderInfoType
    {

        private imsx_GWSVersionValueType imsx_versionField;

        private string imsx_messageIdentifierField;

        private string imsx_sendingAgentIdentifierField;

        private imsx_StatusInfoType imsx_statusInfoField;

        /// <remarks/>
        public imsx_GWSVersionValueType imsx_version
        {
            get
            {
                return this.imsx_versionField;
            }
            set
            {
                this.imsx_versionField = value;
            }
        }

        /// <remarks/>
        public string imsx_messageIdentifier
        {
            get
            {
                return this.imsx_messageIdentifierField;
            }
            set
            {
                this.imsx_messageIdentifierField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string imsx_sendingAgentIdentifier
        {
            get
            {
                return this.imsx_sendingAgentIdentifierField;
            }
            set
            {
                this.imsx_sendingAgentIdentifierField = value;
            }
        }

        /// <remarks/>
        public imsx_StatusInfoType imsx_statusInfo
        {
            get
            {
                return this.imsx_statusInfoField;
            }
            set
            {
                this.imsx_statusInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName = "imsx_POXEnvelope.Type", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0")]
    [XmlRoot("imsx_POXEnvelopeRequest", Namespace = "http://www.imsglobal.org/services/ltiv1p1/xsd/imsoms_v1p0", IsNullable = false)]
    public partial class imsx_POXEnvelopeType
    {

        private imsx_POXHeaderType imsx_POXHeaderField;

        private imsx_POXBodyType imsx_POXBodyField;

        /// <remarks/>
        public imsx_POXHeaderType imsx_POXHeader
        {
            get
            {
                return this.imsx_POXHeaderField;
            }
            set
            {
                this.imsx_POXHeaderField = value;
            }
        }

        /// <remarks/>
        public imsx_POXBodyType imsx_POXBody
        {
            get
            {
                return this.imsx_POXBodyField;
            }
            set
            {
                this.imsx_POXBodyField = value;
            }
        }
    }
}
