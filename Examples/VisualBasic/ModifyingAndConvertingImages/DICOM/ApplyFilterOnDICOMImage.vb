﻿Imports Aspose.Imaging.FileFormats.Dicom
Imports Aspose.Imaging.ImageFilters.FilterOptions
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DICOM
    Class ApplyFilterOnDICOMImage
        Public Shared Sub Run()
            ' ExStart:ApplyFilterOnDICOMImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DICOM()

            ' Load an image          
            Using image As New DicomImage(dataDir & Convert.ToString("image.dcm"))

                ' Supply the filters to DICOM image and Save the results to output path.
                image.Filter(image.Bounds, New MedianFilterOptions(8))
                image.Save(dataDir & Convert.ToString("ApplyFilterOnDICOMImage_out.bmp"), New BmpOptions())

            End Using
            ' ExEnd:ApplyFilterOnDICOMImage
        End Sub
    End Class
End Namespace