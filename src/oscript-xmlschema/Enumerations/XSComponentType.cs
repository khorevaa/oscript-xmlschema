﻿using ScriptEngine;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System.Collections.Generic;

namespace OneScript.XMLSchema
{
  
    [EnumerationType("XSComponentType", "ТипКомпонентыXS")]
    public enum XSComponentType
    {

        [EnumItem("Annotation", "Аннотация")]
        Annotation,

        [EnumItem("Include", "Включение")]
        Include,

        [EnumItem("ModelGroup", "ГруппаМодели")]
        ModelGroup,

        [EnumItem("Documentation", "Документация")]
        Documentation,

        [EnumItem("Import", "Импорт")]
        Import,

        [EnumItem("AppInfo", "ИнформацияПриложения")]
        AppInfo,

        [EnumItem("AttributeUse", "ИспользованиеАтрибута")]
        AttributeUse,

        [EnumItem("MaxInclusiveFacet", "МаксимальноВключающийФасет")]
        MaxInclusiveFacet,

        [EnumItem("MaxExclusiveFacet", "МаксимальноИсключающийФасет")]
        MaxExclusiveFacet,

        [EnumItem("Wildcard", "Маска")]
        Wildcard,

        [EnumItem("MinInclusiveFacet", "МинимальноВключающийФасет")]
        MinInclusiveFacet,

        [EnumItem("MinExclusiveFacet", "МинимальноИсключающийФасет")]
        MinExclusiveFacet,

        [EnumItem("AttributeDeclaration", "ОбъявлениеАтрибута")]
        AttributeDeclaration,

        [EnumItem("NotationDeclaration", "ОбъявлениеНотации")]
        NotationDeclaration,

        [EnumItem("ElementDeclaration", "ОбъявлениеЭлемента")]
        ElementDeclaration,

        [EnumItem("XPathDefinition", "ОпределениеXPath")]
        XPathDefinition,

        [EnumItem("AttributeGroupDefinition", "ОпределениеГруппыАтрибутов")]
        AttributeGroupDefinition,

        [EnumItem("ModelGroupDefinition", "ОпределениеГруппыМодели")]
        ModelGroupDefinition,

        [EnumItem("IdentityConstraintDefinition", "ОпределениеОграниченияИдентичности")]
        IdentityConstraintDefinition,

        [EnumItem("SimpleTypeDefinition", "ОпределениеПростогоТипа")]
        SimpleTypeDefinition,

        [EnumItem("ComplexTypeDefinition", "ОпределениеСоставногоТипа")]
        ComplexTypeDefinition,

        [EnumItem("Redefine", "Переопределение")]
        Redefine,

        [EnumItem("Schema", "Схема")]
        Schema,

        [EnumItem("LengthFacet", "ФасетДлины")]
        LengthFacet,

        [EnumItem("FractionDigitsFacet", "ФасетКоличестваРазрядовДробнойЧасти")]
        FractionDigitsFacet,

        [EnumItem("MaxLengthFacet", "ФасетМаксимальнойДлины")]
        MaxLengthFacet,

        [EnumItem("MinLengthFacet", "ФасетМинимальнойДлины")]
        MinLengthFacet,

        [EnumItem("PatternFacet", "ФасетОбразца")]
        PatternFacet,

        [EnumItem("TotalDigitsFacet", "ФасетОбщегоКоличестваРазрядов")]
        TotalDigitsFacet,

        [EnumItem("EnumerationFacet", "ФасетПеречисления")]
        EnumerationFacet,

        [EnumItem("WhitespaceFacet", "ФасетПробельныхСимволов")]
        WhitespaceFacet,

        [EnumItem("Particle", "Фрагмент")]
        Particle   

    }
}
