﻿Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages
    Class ExportWebPToOtherImageFormats
        Public Shared Sub Run()
            ' ExStart:ExportWebPToOtherImageFormats
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WebPImages()

            ' Load WebP image into the instance of image class.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("asposelogo.webp"))
                ' Save the image in WebP format.
                image__1.Save(dataDir & Convert.ToString("ExportWebPToOtherImageFormats_out.bmp"), New BmpOptions())
            End Using
            ' ExEnd:ExportWebPToOtherImageFormats
        End Sub
    End Class
End Namespace