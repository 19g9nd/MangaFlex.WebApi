﻿#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace MangaFlex.Core.Data.Mangas.ViewModels;
public class AvailableLanguagesVM
{
    public string Id { get; set; }
    public string[] Languages { get; set; } 
}
