﻿// -----------------------------------------------------------------------
//  <copyright file="InputDtoEntityMapProfile.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-01 0:17</last-date>
// -----------------------------------------------------------------------

using System;

using OSharp.Dependency;
using OSharp.Entity;
using OSharp.Mapping;


namespace OSharp.AutoMapper
{
    /// <summary>
    /// 对象映射配对：输入DTO->实体类型
    /// </summary>
    public class InputDtoEntityMapProfile : MapProfileBase<InputDtoTypeFinder, IEntityTypeFinder>, ISingletonDependency
    {
        /// <summary>
        /// 初始化一个<see cref="MapProfileBase{TSourceTypeFinder,TTargetTypeFinder}"/>类型的新实例
        /// </summary>
        public InputDtoEntityMapProfile(InputDtoTypeFinder sourceTypeFinder, IEntityTypeFinder targetTypeFinder)
            : base(sourceTypeFinder, targetTypeFinder)
        { }

        /// <summary>
        /// 重写以定义源类型与目标类型的匹配规则
        /// </summary>
        /// <param name="sourceType">源类型</param>
        /// <param name="targetType">目标类型</param>
        /// <returns>是否匹配</returns>
        protected override bool IsMatch(Type sourceType, Type targetType)
        {
            const string end = "InputDto";
            return sourceType.Name == targetType.Name + end;
        }
    }
}