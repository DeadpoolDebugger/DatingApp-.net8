using System;

namespace API.Entities; // Updated the namespace to follow the appropriate structure. Changed namespace API to namespace API.Entities

/// <summary>
/// Represents a user entity 
/// </summary>
public class AppUser
{
    /// <summary>
    /// Gets or sets the unique identifier for the user
    /// </summary>
    public int Id { get; set; } //'int' is a value type, and its default value is 0

    /// <summary>
    /// Gets or sets the username for the user.
    /// </summary>
    /// <remarks>
    /// The `required` modifier ensures that the property is properly initialized
    /// This avoids runtime issues caused by non-nullable properties not being initialized.
    /// </remarks>
    public required string UserName { get; set; }

    // Explanation:
    // - public string UserName { get; set; }
    // - The original issue occurred because 'string' is a reference type and non-nullable by default in modern C#.
    // - The `required` modifier ensures that the property is properly initialized (e.g., through the constructor or object initializer) before the object can be used.
    // - If you don't want to use `required`, you can also make the property nullable by using `string?`.
    // - The 'required' modifier was introduced in C# 11.
}
