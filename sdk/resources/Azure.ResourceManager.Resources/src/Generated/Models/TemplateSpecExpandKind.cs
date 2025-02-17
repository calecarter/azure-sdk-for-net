// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The TemplateSpecExpandKind. </summary>
    public readonly partial struct TemplateSpecExpandKind : IEquatable<TemplateSpecExpandKind>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TemplateSpecExpandKind"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TemplateSpecExpandKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VersionsValue = "versions";

        /// <summary> Includes version information with the Template Spec. </summary>
        public static TemplateSpecExpandKind Versions { get; } = new TemplateSpecExpandKind(VersionsValue);
        /// <summary> Determines if two <see cref="TemplateSpecExpandKind"/> values are the same. </summary>
        public static bool operator ==(TemplateSpecExpandKind left, TemplateSpecExpandKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TemplateSpecExpandKind"/> values are not the same. </summary>
        public static bool operator !=(TemplateSpecExpandKind left, TemplateSpecExpandKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TemplateSpecExpandKind"/>. </summary>
        public static implicit operator TemplateSpecExpandKind(string value) => new TemplateSpecExpandKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TemplateSpecExpandKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TemplateSpecExpandKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
