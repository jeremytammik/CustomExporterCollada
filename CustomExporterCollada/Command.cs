#region Namespaces
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.Exceptions;
using Autodesk.Revit.UI;
#endregion

namespace CustomExporterCollada
{
  [Transaction( TransactionMode.Manual )]
  public class Command : IExternalCommand
  {
    public Result Execute( 
      ExternalCommandData commandData, 
      ref string message, 
      ElementSet elements )
    {
      UIApplication uiapp = commandData.Application;
      UIDocument uidoc = uiapp.ActiveUIDocument;
      Application app = uiapp.Application;
      Document doc = uidoc.Document;
      View view = doc.ActiveView;

      if( view is View3D )
        ExportView3D( doc, view as View );
      else
        TaskDialog.Show( "Collada Export", 
          "You must be in 3D view to export." );

      return Result.Succeeded;
    }

    static void ExportView3D( 
      Document document, 
      View view3D )
    {
      MyExportContext context = new MyExportContext( 
        document );

      // Create an instance of a custom exporter by 
      // giving it a document and the context.

      CustomExporter exporter = new CustomExporter( 
        document, context );

      // Note: Excluding faces just excludes the calls, 
      // not the actual processing of face tessellation. 
      // Meshes of the faces will still be received by 
      // the context.
      //exporter.IncludeFaces = false;

      exporter.ShouldStopOnError = false;

      try
      {
        exporter.Export( view3D );
      }
      catch( ExternalApplicationException ex )
      {
        Debug.Print( "ExternalApplicationException " 
          + ex.Message );
      }
    }
  }
}
