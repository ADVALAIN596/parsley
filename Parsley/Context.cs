﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parsley {

  /// <summary>
  /// Provides access to Parsley objects
  /// </summary>
  public class Context {
    private Core.FrameGrabber _fg;
    private Core.RenderLoop _rl;
    private Core.CalibrationPattern _pattern;
    private UI.Concrete.ROIHandler _roi_handler;

    public Context(
      Core.FrameGrabber fg, 
      Core.RenderLoop rl, 
      Core.CalibrationPattern pattern,
      UI.Concrete.ROIHandler roi_handler) 
    {
      _fg = fg;
      _rl = rl;
      _pattern = pattern;
      _roi_handler = roi_handler;
    }

    /// <summary>
    /// Access the frame grabber
    /// </summary>
    public Core.FrameGrabber FrameGrabber{
      get { return _fg; }
    }

    /// <summary>
    /// Access the camera
    /// </summary>
    public Core.Camera Camera {
      get { return _fg.Camera; }
    }

    /// <summary>
    /// Access calibration pattern
    /// </summary>
    public Core.CalibrationPattern CalibrationPattern {
      get { return _pattern; }
    }

    /// <summary>
    /// Access the render-loop
    /// </summary>
    public Core.RenderLoop RenderLoop {
      get { return _rl; }
    }

    /// <summary>
    /// Access the viewer
    /// </summary>
    public Draw3D.Viewer Viewer {
      get { return _rl.Viewer; }
    }

    /// <summary>
    /// Access the entity that manages ROIs
    /// </summary>
    public UI.Concrete.ROIHandler ROIHandler {
      get { return _roi_handler; }
    }
  }
}
