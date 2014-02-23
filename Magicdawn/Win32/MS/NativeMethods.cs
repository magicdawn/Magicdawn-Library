using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

/*
 * 2014-2-17 11:03:28
 * 
 * 从WindowBase.dll,MS.Win32命名空间导出
 * 
 * BY Magicdawn
 */

namespace Magicdawn.Win32.MS
{
    public class NativeMethods
    {
        // Fields
        public const int AC_SRC_OVER = 0;
        public const uint ACCESS_SYSTEM_SECURITY = 0x1000000;
        public const int APPCOMMAND_BASS_BOOST = 20;
        public const int APPCOMMAND_BASS_DOWN = 0x13;
        public const int APPCOMMAND_BASS_UP = 0x15;
        public const int APPCOMMAND_BROWSER_BACKWARD = 1;
        public const int APPCOMMAND_BROWSER_FAVORITES = 6;
        public const int APPCOMMAND_BROWSER_FORWARD = 2;
        public const int APPCOMMAND_BROWSER_HOME = 7;
        public const int APPCOMMAND_BROWSER_REFRESH = 3;
        public const int APPCOMMAND_BROWSER_SEARCH = 5;
        public const int APPCOMMAND_BROWSER_STOP = 4;
        public const int APPCOMMAND_CLOSE = 0x1f;
        public const int APPCOMMAND_COPY = 0x24;
        public const int APPCOMMAND_CORRECTION_LIST = 0x2d;
        public const int APPCOMMAND_CUT = 0x25;
        public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 0x2b;
        public const int APPCOMMAND_FIND = 0x1c;
        public const int APPCOMMAND_FORWARD_MAIL = 40;
        public const int APPCOMMAND_HELP = 0x1b;
        public const int APPCOMMAND_LAUNCH_APP1 = 0x11;
        public const int APPCOMMAND_LAUNCH_APP2 = 0x12;
        public const int APPCOMMAND_LAUNCH_MAIL = 15;
        public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 0x10;
        public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 0x34;
        public const int APPCOMMAND_MEDIA_CHANNEL_UP = 0x33;
        public const int APPCOMMAND_MEDIA_FAST_FORWARD = 0x31;
        public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;
        public const int APPCOMMAND_MEDIA_PAUSE = 0x2f;
        public const int APPCOMMAND_MEDIA_PLAY = 0x2e;
        public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;
        public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;
        public const int APPCOMMAND_MEDIA_RECORD = 0x30;
        public const int APPCOMMAND_MEDIA_REWIND = 50;
        public const int APPCOMMAND_MEDIA_STOP = 13;
        public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 0x2c;
        public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 0x19;
        public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 0x18;
        public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 0x1a;
        public const int APPCOMMAND_NEW = 0x1d;
        public const int APPCOMMAND_OPEN = 30;
        public const int APPCOMMAND_PASTE = 0x26;
        public const int APPCOMMAND_PRINT = 0x21;
        public const int APPCOMMAND_REDO = 0x23;
        public const int APPCOMMAND_REPLY_TO_MAIL = 0x27;
        public const int APPCOMMAND_SAVE = 0x20;
        public const int APPCOMMAND_SEND_MAIL = 0x29;
        public const int APPCOMMAND_SPELL_CHECK = 0x2a;
        public const int APPCOMMAND_TREBLE_DOWN = 0x16;
        public const int APPCOMMAND_TREBLE_UP = 0x17;
        public const int APPCOMMAND_UNDO = 0x22;
        public const int APPCOMMAND_VOLUME_DOWN = 9;
        public const int APPCOMMAND_VOLUME_MUTE = 8;
        public const int APPCOMMAND_VOLUME_UP = 10;
        public const int ATTR_CONVERTED = 2;
        public const int ATTR_FIXEDCONVERTED = 5;
        public const int ATTR_INPUT = 0;
        public const int ATTR_INPUT_ERROR = 4;
        public const int ATTR_TARGET_CONVERTED = 1;
        public const int ATTR_TARGET_NOTCONVERTED = 3;
        public const int BI_RGB = 0;
        public const int BITMAPINFO_MAX_COLORSIZE = 0x100;
        public const int BITSPIXEL = 12;
        public const int CB_ADDSTRING = 0x143;
        public const int CB_DELETESTRING = 0x144;
        public const int CB_ERR = -1;
        public const int CB_FINDSTRING = 0x14c;
        public const int CB_FINDSTRINGEXACT = 0x158;
        public const int CB_GETCURSEL = 0x147;
        public const int CB_GETDROPPEDSTATE = 0x157;
        public const int CB_GETEDITSEL = 320;
        public const int CB_GETITEMDATA = 0x150;
        public const int CB_GETITEMHEIGHT = 340;
        public const int CB_GETLBTEXT = 0x148;
        public const int CB_GETLBTEXTLEN = 0x149;
        public const int CB_INSERTSTRING = 330;
        public const int CB_LIMITTEXT = 0x141;
        public const int CB_RESETCONTENT = 0x14b;
        public const int CB_SETCURSEL = 0x14e;
        public const int CB_SETDROPPEDWIDTH = 0x160;
        public const int CB_SETEDITSEL = 0x142;
        public const int CB_SETITEMHEIGHT = 0x153;
        public const int CB_SHOWDROPDOWN = 0x14f;
        public const int CBEM_GETITEMA = 0x404;
        public const int CBEM_GETITEMW = 0x40d;
        public const int CBEM_INSERTITEMA = 0x401;
        public const int CBEM_INSERTITEMW = 0x40b;
        public const int CBEM_SETITEMA = 0x405;
        public const int CBEM_SETITEMW = 0x40c;
        public const int CBEN_ENDEDITA = -805;
        public const int CBEN_ENDEDITW = -806;
        public const int CBN_CLOSEUP = 8;
        public const int CBN_DBLCLK = 2;
        public const int CBN_DROPDOWN = 7;
        public const int CBN_EDITCHANGE = 5;
        public const int CBN_EDITUPDATE = 6;
        public const int CBN_SELCHANGE = 1;
        public const int CBN_SELENDOK = 9;
        public const int CBS_AUTOHSCROLL = 0x40;
        public const int CBS_DROPDOWN = 2;
        public const int CBS_DROPDOWNLIST = 3;
        public const int CBS_HASSTRINGS = 0x200;
        public const int CBS_NOINTEGRALHEIGHT = 0x400;
        public const int CBS_OWNERDRAWFIXED = 0x10;
        public const int CBS_OWNERDRAWVARIABLE = 0x20;
        public const int CBS_SIMPLE = 1;
        public const int CCM_GETVERSION = 0x2008;
        public const int CCM_SETVERSION = 0x2007;
        public const int CCS_NODIVIDER = 0x40;
        public const int CCS_NOPARENTALIGN = 8;
        public const int CCS_NORESIZE = 4;
        public const int CDDS_ITEM = 0x10000;
        public const int CDDS_ITEMPOSTPAINT = 0x10002;
        public const int CDDS_ITEMPREPAINT = 0x10001;
        public const int CDDS_POSTPAINT = 2;
        public const int CDDS_PREPAINT = 1;
        public const int CDDS_SUBITEM = 0x20000;
        public const int CDIS_CHECKED = 8;
        public const int CDIS_DEFAULT = 0x20;
        public const int CDIS_DISABLED = 4;
        public const int CDIS_FOCUS = 0x10;
        public const int CDIS_GRAYED = 2;
        public const int CDIS_HOT = 0x40;
        public const int CDIS_INDETERMINATE = 0x100;
        public const int CDIS_MARKED = 0x80;
        public const int CDIS_SELECTED = 1;
        public const int CDIS_SHOWKEYBOARDCUES = 0x200;
        public const int CDM_FIRST = 0x464;
        public const int CDM_GETFILEPATH = 0x465;
        public const int CDM_GETSPEC = 0x464;
        public const int CDN_FILEOK = -606;
        public const int CDN_FIRST = -601;
        public const int CDN_INITDONE = -601;
        public const int CDN_SELCHANGE = -602;
        public const int CDN_SHAREVIOLATION = -604;
        public const int CDRF_DODEFAULT = 0;
        public const int CDRF_NEWFONT = 2;
        public const int CDRF_NOTIFYITEMDRAW = 0x20;
        public const int CDRF_NOTIFYPOSTPAINT = 0x10;
        public const int CDRF_NOTIFYSUBITEMDRAW = 0x20;
        public const int CDRF_SKIPDEFAULT = 4;
        public const int CF_BITMAP = 2;
        public const int CF_DIB = 8;
        public const int CF_DIF = 5;
        public const int CF_ENHMETAFILE = 14;
        public const int CF_HDROP = 15;
        public const int CF_LOCALE = 0x10;
        public const int CF_METAFILEPICT = 3;
        public const int CF_OEMTEXT = 7;
        public const int CF_PALETTE = 9;
        public const int CF_PENDATA = 10;
        public const int CF_RIFF = 11;
        public const int CF_SYLK = 4;
        public const int CF_TEXT = 1;
        public const int CF_TIFF = 6;
        public const int CF_UNICODETEXT = 13;
        public const int CF_WAVE = 12;
        public const int CFS_CANDIDATEPOS = 0x40;
        public const int CFS_DEFAULT = 0;
        public const int CFS_EXCLUDE = 0x80;
        public const int CFS_FORCE_POSITION = 0x20;
        public const int CFS_POINT = 2;
        public const int CFS_RECT = 1;
        public const int CLR_DEFAULT = -16777216;
        public const int CLR_NONE = -1;
        public const int CLSCTX_INPROC_SERVER = 1;
        public const int CLSCTX_LOCAL_SERVER = 4;
        public const int cmb4 = 0x473;
        public const int COLOR_WINDOW = 5;
        public const int CONNECT_E_CANNOTCONNECT = -2147220990;
        public const int CONNECT_E_NOCONNECTION = -2147220992;
        public const int CPS_CANCEL = 4;
        public const int CPS_COMPLETE = 1;
        public const int CREATE_ALWAYS = 2;
        public const int CS_DBLCLKS = 8;
        public const int CS_DROPSHADOW = 0x20000;
        public const int CS_SAVEBITS = 0x800;
        public const int CSC_NAVIGATEBACK = 2;
        public const int CSC_NAVIGATEFORWARD = 1;
        public const int CSIDL_APPDATA = 0x1a;
        public const int CSIDL_COMMON_APPDATA = 0x23;
        public const int CSIDL_COOKIES = 0x21;
        public const int CSIDL_DESKTOP = 0;
        public const int CSIDL_DESKTOPDIRECTORY = 0x10;
        public const int CSIDL_FAVORITES = 6;
        public const int CSIDL_HISTORY = 0x22;
        public const int CSIDL_INTERNET = 1;
        public const int CSIDL_INTERNET_CACHE = 0x20;
        public const int CSIDL_LOCAL_APPDATA = 0x1c;
        public const int CSIDL_PERSONAL = 5;
        public const int CSIDL_PROGRAM_FILES = 0x26;
        public const int CSIDL_PROGRAM_FILES_COMMON = 0x2b;
        public const int CSIDL_PROGRAMS = 2;
        public const int CSIDL_RECENT = 8;
        public const int CSIDL_SENDTO = 9;
        public const int CSIDL_STARTMENU = 11;
        public const int CSIDL_STARTUP = 7;
        public const int CSIDL_SYSTEM = 0x25;
        public const int CSIDL_TEMPLATES = 0x15;
        public const int CTRLINFO_EATS_ESCAPE = 2;
        public const int CTRLINFO_EATS_RETURN = 1;
        public const int CW_USEDEFAULT = -2147483648;
        public const int CWP_SKIPINVISIBLE = 1;
        public const int DCX_CACHE = 2;
        public const int DCX_LOCKWINDOWUPDATE = 0x400;
        public const int DCX_WINDOW = 1;
        public const int DEFAULT_GUI_FONT = 0x11;
        public const uint DELETE = 0x10000;
        public const int DFC_BUTTON = 4;
        public const int DFC_CAPTION = 1;
        public const int DFC_MENU = 2;
        public const int DFC_SCROLL = 3;
        public const int DFCS_BUTTON3STATE = 8;
        public const int DFCS_BUTTONCHECK = 0;
        public const int DFCS_BUTTONPUSH = 0x10;
        public const int DFCS_BUTTONRADIO = 4;
        public const int DFCS_CAPTIONCLOSE = 0;
        public const int DFCS_CAPTIONHELP = 4;
        public const int DFCS_CAPTIONMAX = 2;
        public const int DFCS_CAPTIONMIN = 1;
        public const int DFCS_CAPTIONRESTORE = 3;
        public const int DFCS_CHECKED = 0x400;
        public const int DFCS_FLAT = 0x4000;
        public const int DFCS_INACTIVE = 0x100;
        public const int DFCS_MENUARROW = 0;
        public const int DFCS_MENUBULLET = 2;
        public const int DFCS_MENUCHECK = 1;
        public const int DFCS_PUSHED = 0x200;
        public const int DFCS_SCROLLCOMBOBOX = 5;
        public const int DFCS_SCROLLDOWN = 1;
        public const int DFCS_SCROLLLEFT = 2;
        public const int DFCS_SCROLLRIGHT = 3;
        public const int DFCS_SCROLLUP = 0;
        public const int DI_NORMAL = 3;
        public const int DIB_RGB_COLORS = 0;
        public const int DISPATCH_METHOD = 1;
        public const int DISPATCH_PROPERTYGET = 2;
        public const int DISPATCH_PROPERTYPUT = 4;
        public const int DISPATCH_PROPERTYPUTREF = 8;
        public const int DISPID_PROPERTYPUT = -3;
        public const int DISPID_UNKNOWN = -1;
        public const int DISPID_VALUE = 0;
        public const int DLGC_WANTALLKEYS = 4;
        public const int DLGC_WANTARROWS = 1;
        public const int DLGC_WANTCHARS = 0x80;
        public const int DLGC_WANTTAB = 2;
        public const int DM_ORIENTATION = 1;
        public const int DM_OUT_BUFFER = 2;
        public const int DM_PAPERLENGTH = 4;
        public const int DM_PAPERSIZE = 2;
        public const int DM_PAPERWIDTH = 8;
        public const int DM_PRINTQUALITY = 0x400;
        public const int DM_YRESOLUTION = 0x2000;
        public const int DRAGDROP_E_ALREADYREGISTERED = -2147221247;
        public const int DRAGDROP_E_NOTREGISTERED = -2147221248;
        public const int DRAGDROP_S_CANCEL = 0x40101;
        public const int DRAGDROP_S_DROP = 0x40100;
        public const int DRAGDROP_S_USEDEFAULTCURSORS = 0x40102;
        public const int DT_CALCRECT = 0x400;
        public const int DT_EDITCONTROL = 0x2000;
        public const int DT_END_ELLIPSIS = 0x8000;
        public const int DT_EXPANDTABS = 0x40;
        public const int DT_LEFT = 0;
        public const int DT_NOCLIP = 0x100;
        public const int DT_NOPREFIX = 0x800;
        public const int DT_RIGHT = 2;
        public const int DT_RTLREADING = 0x20000;
        public const int DT_SINGLELINE = 0x20;
        public const int DT_VCENTER = 4;
        public const int DT_WORDBREAK = 0x10;
        public const int DTM_GETSYSTEMTIME = 0x1001;
        public const int DTM_SETFORMATA = 0x1005;
        public const int DTM_SETFORMATW = 0x1032;
        public const int DTM_SETMCCOLOR = 0x1006;
        public const int DTM_SETMCFONT = 0x1009;
        public const int DTM_SETRANGE = 0x1004;
        public const int DTM_SETSYSTEMTIME = 0x1002;
        public const int DTN_CLOSEUP = -753;
        public const int DTN_DATETIMECHANGE = -759;
        public const int DTN_DROPDOWN = -754;
        public const int DTN_FORMATA = -756;
        public const int DTN_FORMATQUERYA = -755;
        public const int DTN_FORMATQUERYW = -742;
        public const int DTN_FORMATW = -743;
        public const int DTN_USERSTRINGA = -758;
        public const int DTN_USERSTRINGW = -745;
        public const int DTN_WMKEYDOWNA = -757;
        public const int DTN_WMKEYDOWNW = -744;
        public const int DTS_LONGDATEFORMAT = 4;
        public const int DTS_RIGHTALIGN = 0x20;
        public const int DTS_SHOWNONE = 2;
        public const int DTS_TIMEFORMAT = 9;
        public const int DTS_UPDOWN = 1;
        public const int DUPLICATE = 6;
        public const int DUPLICATE_SAME_ACCESS = 2;
        public const int DV_E_DVASPECT = -2147221397;
        public const int DVASPECT_CONTENT = 1;
        public const int DVASPECT_OPAQUE = 0x10;
        public const int DVASPECT_TRANSPARENT = 0x20;
        public const int DWL_MSGRESULT = 0;
        public const int E_ABORT = -2147467260;
        public const int E_FAIL = -2147467259;
        public const int E_HANDLE = -2147024890;
        public const int E_INVALIDARG = -2147024809;
        public const int E_NOINTERFACE = -2147467262;
        public const int E_NOTIMPL = -2147467263;
        public const int E_OUTOFMEMORY = -2147024882;
        public const int E_UNEXPECTED = -2147418113;
        public const int EC_LEFTMARGIN = 1;
        public const int EC_RIGHTMARGIN = 2;
        public const int EDGE_BUMP = 9;
        public const int EDGE_ETCHED = 6;
        public const int EDGE_RAISED = 5;
        public const int EDGE_SUNKEN = 10;
        public const int EM_CANUNDO = 0xc6;
        public const int EM_CHARFROMPOS = 0xd7;
        public const int EM_EMPTYUNDOBUFFER = 0xcd;
        public const int EM_GETLINE = 0xc4;
        public const int EM_GETLINECOUNT = 0xba;
        public const int EM_GETMODIFY = 0xb8;
        public const int EM_GETPASSWORDCHAR = 210;
        public const int EM_GETSEL = 0xb0;
        public const int EM_LIMITTEXT = 0xc5;
        public const int EM_LINEFROMCHAR = 0xc9;
        public const int EM_LINEINDEX = 0xbb;
        public const int EM_POSFROMCHAR = 0xd6;
        public const int EM_REPLACESEL = 0xc2;
        public const int EM_SCROLL = 0xb5;
        public const int EM_SCROLLCARET = 0xb7;
        public const int EM_SETMARGINS = 0xd3;
        public const int EM_SETMODIFY = 0xb9;
        public const int EM_SETPASSWORDCHAR = 0xcc;
        public const int EM_SETREADONLY = 0xcf;
        public const int EM_SETSEL = 0xb1;
        public const int EM_UNDO = 0xc7;
        public const int EMR_POLYTEXTOUTA = 0x60;
        public const int EMR_POLYTEXTOUTW = 0x61;
        public const int EN_ALIGN_LTR_EC = 0x700;
        public const int EN_ALIGN_RTL_EC = 0x701;
        public const int EN_CHANGE = 0x300;
        public const int EN_HSCROLL = 0x601;
        public const int EN_UPDATE = 0x400;
        public const int EN_VSCROLL = 0x602;
        public const int ENDSESSION_LOGOFF = -2147483648;
        public const int ERROR = 0;
        public const int ERROR_ACCESS_DENIED = 5;
        public const int ERROR_ALREADY_EXISTS = 0xb7;
        public const int ERROR_FILE_EXISTS = 80;
        public const int ERROR_FILE_NOT_FOUND = 2;
        public const int ERROR_FILENAME_EXCED_RANGE = 0xce;
        public const int ERROR_INVALID_DRIVE = 15;
        public const int ERROR_INVALID_PARAMETER = 0x57;
        public const int ERROR_NO_MORE_ITEMS = 0x103;
        public const int ERROR_OPERATION_ABORTED = 0x3e3;
        public const int ERROR_PATH_NOT_FOUND = 3;
        public const int ERROR_SHARING_VIOLATION = 0x20;
        public const int ERROR_SUCCESS = 0;
        public const int ES_AUTOHSCROLL = 0x80;
        public const int ES_AUTOVSCROLL = 0x40;
        public const int ES_CENTER = 1;
        public const int ES_LEFT = 0;
        public const int ES_LOWERCASE = 0x10;
        public const int ES_MULTILINE = 4;
        public const int ES_NOHIDESEL = 0x100;
        public const int ES_PASSWORD = 0x20;
        public const int ES_READONLY = 0x800;
        public const int ES_RIGHT = 2;
        public const int ES_UPPERCASE = 8;
        public const int ESB_DISABLE_BOTH = 3;
        public const int ESB_ENABLE_BOTH = 0;
        public const int ETO_CLIPPED = 4;
        public const int ETO_OPAQUE = 2;
        public const int EVENT_OBJECT_FOCUS = 0x8005;
        public const int EVENT_OBJECT_STATECHANGE = 0x800a;
        public const int EVENT_SYSTEM_MOVESIZEEND = 11;
        public const int EVENT_SYSTEM_MOVESIZESTART = 10;
        public const int FAPPCOMMAND_KEY = 0;
        public const int FAPPCOMMAND_MASK = 0xf000;
        public const int FAPPCOMMAND_MOUSE = 0x8000;
        public const int FAPPCOMMAND_OEM = 0x1000;
        public const int FEATURE_ADDON_MANAGEMENT = 13;
        public const int FEATURE_BEHAVIORS = 6;
        public const int FEATURE_BLOCK_INPUT_PROMPTS = 0x1b;
        public const int FEATURE_DISABLE_LEGACY_COMPRESSION = 0x16;
        public const int FEATURE_DISABLE_MK_PROTOCOL = 7;
        public const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 0x15;
        public const int FEATURE_DISABLE_TELNET_PROTOCOL = 0x19;
        public const int FEATURE_FEEDS = 0x1a;
        public const int FEATURE_FORCE_ADDR_AND_STATUS = 0x17;
        public const int FEATURE_GET_URL_DOM_FILEPATH_UNENCODED = 0x12;
        public const int FEATURE_HTTP_USERNAME_PASSWORD_DISABLE = 15;
        public const int FEATURE_LOCALMACHINE_LOCKDOWN = 8;
        public const int FEATURE_MIME_HANDLING = 2;
        public const int FEATURE_MIME_SNIFFING = 3;
        public const int FEATURE_OBJECT_CACHING = 0;
        public const int FEATURE_PROTOCOL_LOCKDOWN = 14;
        public const int FEATURE_RESTRICT_ACTIVEXINSTALL = 10;
        public const int FEATURE_RESTRICT_FILEDOWNLOAD = 12;
        public const int FEATURE_SAFE_BINDTOOBJECT = 0x10;
        public const int FEATURE_SECURITYBAND = 9;
        public const int FEATURE_SSLUX = 20;
        public const int FEATURE_TABBED_BROWSING = 0x13;
        public const int FEATURE_UNC_SAVEDFILECHECK = 0x11;
        public const int FEATURE_VALIDATE_NAVIGATE_URL = 11;
        public const int FEATURE_WEBOC_POPUPMANAGEMENT = 5;
        public const int FEATURE_WINDOW_RESTRICTIONS = 4;
        public const int FEATURE_XMLHTTP = 0x18;
        public const int FEATURE_ZONE_ELEVATION = 1;
        public const uint FILE_ADD_FILE = 2;
        public const uint FILE_ADD_SUBDIRECTORY = 4;
        public const uint FILE_ALL_ACCESS = 0x1f01ff;
        public const uint FILE_APPEND_DATA = 4;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x100;
        public const uint FILE_CREATE_PIPE_INSTANCE = 4;
        public const uint FILE_DELETE_CHILD = 0x40;
        public const uint FILE_EXECUTE = 0x20;
        public const int FILE_FLAG_DELETE_ON_CLOSE = 0x4000000;
        public const uint FILE_GENERIC_EXECUTE = 0x1200a0;
        public const uint FILE_GENERIC_READ = 0x120089;
        public const uint FILE_GENERIC_WRITE = 0x120116;
        public const uint FILE_LIST_DIRECTORY = 1;
        public const int FILE_MAP_READ = 4;
        public const uint FILE_READ_ATTRIBUTES = 0x80;
        public const uint FILE_READ_DATA = 1;
        public const uint FILE_READ_EA = 8;
        public const uint FILE_SHARE_DELETE = 4;
        public const uint FILE_SHARE_READ = 1;
        public const uint FILE_SHARE_WRITE = 2;
        public const uint FILE_TRAVERSE = 0x20;
        public const uint FILE_WRITE_ATTRIBUTES = 0x100;
        public const uint FILE_WRITE_DATA = 2;
        public const uint FILE_WRITE_EA = 0x10;
        public const int FNERR_BUFFERTOOSMALL = 0x3003;
        public const int FNERR_INVALIDFILENAME = 0x3002;
        public const int FNERR_SUBCLASSFAILURE = 0x3001;
        public const int GA_PARENT = 1;
        public const int GA_ROOT = 2;
        public const int GCL_CBCLSEXTRA = -20;
        public const int GCL_CBWNDEXTRA = -18;
        public const int GCL_HBRBACKGROUND = -10;
        public const int GCL_HCURSOR = -12;
        public const int GCL_HICON = -14;
        public const int GCL_HICONSM = -34;
        public const int GCL_HMODULE = -16;
        public const int GCL_MENUNAME = -8;
        public const int GCL_STYLE = -26;
        public const int GCL_WNDPROC = -24;
        public const int GCS_COMPATTR = 0x10;
        public const int GCS_COMPCLAUSE = 0x20;
        public const int GCS_COMPREADATTR = 2;
        public const int GCS_COMPREADCLAUSE = 4;
        public const int GCS_COMPREADSTR = 1;
        public const int GCS_COMPSTR = 8;
        public const int GCS_CURSORPOS = 0x80;
        public const int GCS_DELTASTART = 0x100;
        public const int GCS_RESULTCLAUSE = 0x1000;
        public const int GCS_RESULTREADCLAUSE = 0x400;
        public const int GCS_RESULTREADSTR = 0x200;
        public const int GCS_RESULTSTR = 0x800;
        public const int GCW_ATOM = -32;
        public const int GDI_ERROR = -1;
        public const int GDT_NONE = 1;
        public const int GDT_VALID = 0;
        public const int GDTR_MAX = 2;
        public const int GDTR_MIN = 1;
        public const uint GENERIC_ALL = 0x10000000;
        public const uint GENERIC_EXECUTE = 0x20000000;
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const int GET_FEATURE_FROM_PROCESS = 2;
        public const int GMEM_DDESHARE = 0x2000;
        public const int GMEM_MOVEABLE = 2;
        public const int GMEM_ZEROINIT = 0x40;
        public const int GMMP_USE_DISPLAY_POINTS = 1;
        public const int GMMP_USE_HIGH_RESOLUTION_POINTS = 2;
        public const int GMR_DAYSTATE = 1;
        public const int GMR_VISIBLE = 0;
        public static readonly Guid GUID_MONITOR_POWER_ON = new Guid(0x2731015, 0x4510, 0x4526, 0x99, 230, 0xe5, 0xa1, 0x7e, 0xbd, 0x1a, 0xea);
        public const int GW_CHILD = 5;
        public const int GW_HWNDFIRST = 0;
        public const int GW_HWNDLAST = 1;
        public const int GW_HWNDNEXT = 2;
        public const int GW_HWNDPREV = 3;
        public const int GWL_EXSTYLE = -20;
        public const int GWL_HINSTANCE = -6;
        public const int GWL_HWNDPARENT = -8;
        public const int GWL_ID = -12;
        public const int GWL_STYLE = -16;
        public const int GWL_USERDATA = -21;
        public const int GWL_WNDPROC = -4;
        public const int HC_ACTION = 0;
        public const int HC_GETNEXT = 1;
        public const int HC_SKIP = 2;
        public const int HCF_HIGHCONTRASTON = 1;
        public const int HDI_ORDER = 0x80;
        public const int HDI_WIDTH = 1;
        public const int HDM_GETITEMA = 0x1203;
        public const int HDM_GETITEMCOUNT = 0x1200;
        public const int HDM_GETITEMW = 0x120b;
        public const int HDM_INSERTITEMA = 0x1201;
        public const int HDM_INSERTITEMW = 0x120a;
        public const int HDM_SETITEMA = 0x1204;
        public const int HDM_SETITEMW = 0x120c;
        public const int HDN_BEGINTDRAG = -310;
        public const int HDN_BEGINTRACKA = -306;
        public const int HDN_BEGINTRACKW = -326;
        public const int HDN_DIVIDERDBLCLICKA = -305;
        public const int HDN_DIVIDERDBLCLICKW = -325;
        public const int HDN_ENDDRAG = -311;
        public const int HDN_ENDTRACKA = -307;
        public const int HDN_ENDTRACKW = -327;
        public const int HDN_GETDISPINFOA = -309;
        public const int HDN_GETDISPINFOW = -329;
        public const int HDN_ITEMCHANGEDA = -301;
        public const int HDN_ITEMCHANGEDW = -321;
        public const int HDN_ITEMCHANGINGA = -300;
        public const int HDN_ITEMCHANGINGW = -320;
        public const int HDN_ITEMCLICKA = -302;
        public const int HDN_ITEMCLICKW = -322;
        public const int HDN_ITEMDBLCLICKA = -303;
        public const int HDN_ITEMDBLCLICKW = -323;
        public const int HDN_TRACKA = -308;
        public const int HDN_TRACKW = -328;
        public const int HELPINFO_WINDOW = 1;
        public const ushort HID_USAGE_DIGITIZER_DIGITIZER = 1;
        public const ushort HID_USAGE_DIGITIZER_LIGHTPEN = 3;
        public const ushort HID_USAGE_DIGITIZER_PEN = 2;
        public const ushort HID_USAGE_DIGITIZER_TOUCHSCREEN = 4;
        public const ushort HID_USAGE_PAGE_DIGITIZER = 13;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 0x10;
        public const int HTBOTTOMRIGHT = 0x11;
        public const int HTCLIENT = 1;
        public const int HTNOWHERE = 0;
        public const int HTTRANSPARENT = -1;
        public static HandleRef HWND_BOTTOM = new HandleRef(null, (IntPtr)1);
        public static IntPtr HWND_MESSAGE = new IntPtr(-3);
        public static HandleRef HWND_NOTOPMOST = new HandleRef(null, new IntPtr(-2));
        public static HandleRef HWND_TOP = new HandleRef(null, IntPtr.Zero);
        public static HandleRef HWND_TOPMOST = new HandleRef(null, new IntPtr(-1));
        public const int ICC_BAR_CLASSES = 4;
        public const int ICC_DATE_CLASSES = 0x100;
        public const int ICC_LISTVIEW_CLASSES = 1;
        public const int ICC_PROGRESS_CLASS = 0x20;
        public const int ICC_TAB_CLASSES = 8;
        public const int ICC_TREEVIEW_CLASSES = 2;
        public const int ICON_BIG = 1;
        public const int ICON_SMALL = 0;
        public const int IDC_APPSTARTING = 0x7f8a;
        public const int IDC_ARROW = 0x7f00;
        public const int IDC_CROSS = 0x7f03;
        public const int IDC_HAND = 0x7f89;
        public const int IDC_HELP = 0x7f8b;
        public const int IDC_IBEAM = 0x7f01;
        public const int IDC_NO = 0x7f88;
        public const int IDC_SIZEALL = 0x7f86;
        public const int IDC_SIZENESW = 0x7f83;
        public const int IDC_SIZENS = 0x7f85;
        public const int IDC_SIZENWSE = 0x7f82;
        public const int IDC_SIZEWE = 0x7f84;
        public const int IDC_UPARROW = 0x7f04;
        public const int IDC_WAIT = 0x7f02;
        public const int IDYES = 6;
        public const int IGP_CONVERSION = 8;
        public const int IGP_GETIMEVERSION = -4;
        public const int IGP_PROPERTY = 4;
        public const int IGP_SELECT = 0x18;
        public const int IGP_SENTENCE = 12;
        public const int IGP_SETCOMPSTR = 20;
        public const int IGP_UI = 0x10;
        public const int ILC_COLOR = 0;
        public const int ILC_COLOR16 = 0x10;
        public const int ILC_COLOR24 = 0x18;
        public const int ILC_COLOR32 = 0x20;
        public const int ILC_COLOR4 = 4;
        public const int ILC_COLOR8 = 8;
        public const int ILC_MASK = 1;
        public const int ILC_MIRROR = 0x2000;
        public const int ILD_MASK = 0x10;
        public const int ILD_NORMAL = 0;
        public const int ILD_ROP = 0x40;
        public const int ILD_TRANSPARENT = 1;
        public const int ILP_DOWNLEVEL = 1;
        public const int ILP_NORMAL = 0;
        public const int ILS_ALPHA = 8;
        public const int ILS_GLOW = 1;
        public const int ILS_NORMAL = 0;
        public const int ILS_SATURATE = 4;
        public const int ILS_SHADOW = 2;
        public const int IMAGE_CURSOR = 2;
        public const int IMAGE_ICON = 1;
        public const int IME_CAND_CODE = 2;
        public const int IME_CAND_MEANING = 3;
        public const int IME_CAND_RADICAL = 4;
        public const int IME_CAND_READ = 1;
        public const int IME_CAND_STROKE = 5;
        public const int IME_CAND_UNKNOWN = 0;
        public const int IME_CMODE_ALPHANUMERIC = 0;
        public const int IME_CMODE_CHARCODE = 0x20;
        public const int IME_CMODE_CHINESE = 1;
        public const int IME_CMODE_EUDC = 0x200;
        public const int IME_CMODE_FIXED = 0x800;
        public const int IME_CMODE_FULLSHAPE = 8;
        public const int IME_CMODE_HANGEUL = 1;
        public const int IME_CMODE_HANGUL = 1;
        public const int IME_CMODE_HANJACONVERT = 0x40;
        public const int IME_CMODE_JAPANESE = 1;
        public const int IME_CMODE_KATAKANA = 2;
        public const int IME_CMODE_LANGUAGE = 3;
        public const int IME_CMODE_NATIVE = 1;
        public const int IME_CMODE_NOCONVERSION = 0x100;
        public const int IME_CMODE_RESERVED = -268435456;
        public const int IME_CMODE_ROMAN = 0x10;
        public const int IME_CMODE_SOFTKBD = 0x80;
        public const int IME_CMODE_SYMBOL = 0x400;
        public const int IME_CONFIG_GENERAL = 1;
        public const int IME_CONFIG_REGISTERWORD = 2;
        public const int IME_CONFIG_SELECTDICTIONARY = 3;
        public const int IME_PROP_AT_CARET = 0x10000;
        public const int IME_PROP_CANDLIST_START_FROM_1 = 0x40000;
        public const int IME_PROP_COMPLETE_ON_UNSELECT = 0x100000;
        public const int IME_PROP_SPECIAL_UI = 0x20000;
        public const int IME_PROP_UNICODE = 0x80000;
        public const int IME_SMODE_AUTOMATIC = 4;
        public const int IME_SMODE_CONVERSATION = 0x10;
        public const int IME_SMODE_NONE = 0;
        public const int IME_SMODE_PHRASEPREDICT = 8;
        public const int IME_SMODE_PLAURALCLAUSE = 1;
        public const int IME_SMODE_RESERVED = 0xf000;
        public const int IME_SMODE_SINGLECONVERT = 2;
        public const int IMN_CHANGECANDIDATE = 3;
        public const int IMN_CLOSECANDIDATE = 4;
        public const int IMN_CLOSESTATUSWINDOW = 1;
        public const int IMN_GUIDELINE = 13;
        public const int IMN_OPENCANDIDATE = 5;
        public const int IMN_OPENSTATUSWINDOW = 2;
        public const int IMN_PRIVATE = 14;
        public const int IMN_SETCANDIDATEPOS = 9;
        public const int IMN_SETCOMPOSITIONFONT = 10;
        public const int IMN_SETCOMPOSITIONWINDOW = 11;
        public const int IMN_SETCONVERSIONMODE = 6;
        public const int IMN_SETOPENSTATUS = 8;
        public const int IMN_SETSENTENCEMODE = 7;
        public const int IMN_SETSTATUSWINDOWPOS = 12;
        public const int IMR_CANDIDATEWINDOW = 2;
        public const int IMR_COMPOSITIONFONT = 3;
        public const int IMR_COMPOSITIONWINDOW = 1;
        public const int IMR_CONFIRMRECONVERTSTRING = 5;
        public const int IMR_DOCUMENTFEED = 7;
        public const int IMR_QUERYCHARPOSITION = 6;
        public const int IMR_RECONVERTSTRING = 4;
        public const int INET_E_DEFAULT_ACTION = -2146697199;
        public const int INPLACE_E_NOTOOLSPACE = -2147221087;
        public static IntPtr InvalidIntPtr = ((IntPtr)(-1));
        public const int KEYEVENTF_EXTENDEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 2;
        public const int KEYEVENTF_SCANCODE = 8;
        public const int KEYEVENTF_UNICODE = 4;
        public const int LANG_KOREAN = 0x12;
        public const int LB_ADDSTRING = 0x180;
        public const int LB_DELETESTRING = 0x182;
        public const int LB_ERR = -1;
        public const int LB_ERRSPACE = -2;
        public const int LB_FINDSTRING = 0x18f;
        public const int LB_FINDSTRINGEXACT = 0x1a2;
        public const int LB_GETCARETINDEX = 0x19f;
        public const int LB_GETCURSEL = 0x188;
        public const int LB_GETITEMHEIGHT = 0x1a1;
        public const int LB_GETITEMRECT = 0x198;
        public const int LB_GETSEL = 0x187;
        public const int LB_GETSELCOUNT = 400;
        public const int LB_GETSELITEMS = 0x191;
        public const int LB_GETTEXT = 0x189;
        public const int LB_GETTEXTLEN = 0x18a;
        public const int LB_GETTOPINDEX = 0x18e;
        public const int LB_INSERTSTRING = 0x181;
        public const int LB_ITEMFROMPOINT = 0x1a9;
        public const int LB_RESETCONTENT = 0x184;
        public const int LB_SETCOLUMNWIDTH = 0x195;
        public const int LB_SETCURSEL = 390;
        public const int LB_SETHORIZONTALEXTENT = 0x194;
        public const int LB_SETITEMHEIGHT = 0x1a0;
        public const int LB_SETLOCALE = 0x1a5;
        public const int LB_SETSEL = 0x185;
        public const int LB_SETTABSTOPS = 0x192;
        public const int LB_SETTOPINDEX = 0x197;
        public const int LBN_DBLCLK = 2;
        public const int LBN_SELCHANGE = 1;
        public const int LOCALE_FONTSIGNATURE = 0x58;
        public const int LOGPIXELSX = 0x58;
        public const int LOGPIXELSY = 90;
        public static IntPtr LPSTR_TEXTCALLBACK = ((IntPtr)(-1));
        public const int LR_COLOR = 2;
        public const int LR_COPYDELETEORG = 8;
        public const int LR_COPYFROMRESOURCE = 0x4000;
        public const int LR_COPYRETURNORG = 4;
        public const int LR_CREATEDIBSECTION = 0x2000;
        public const int LR_DEFAULTCOLOR = 0;
        public const int LR_DEFAULTSIZE = 0x40;
        public const int LR_LOADFROMFILE = 0x10;
        public const int LR_LOADMAP3DCOLORS = 0x1000;
        public const int LR_LOADTRANSPARENT = 0x20;
        public const int LR_MONOCHROME = 1;
        public const int LR_SHARED = 0x8000;
        public const int LR_VGACOLOR = 0x80;
        public const int LWA_ALPHA = 2;
        public const int MA_ACTIVATE = 1;
        public const int MA_ACTIVATEANDEAT = 2;
        public const int MA_NOACTIVATE = 3;
        public const int MA_NOACTIVATEANDEAT = 4;
        public const int MAX_PATH = 260;
        public const uint MAXIMUM_ALLOWED = 0x2000000;
        public const int MB_ICONASTERISK = 0x40;
        public const int MB_ICONEXCLAMATION = 0x30;
        public const int MB_ICONHAND = 0x10;
        public const int MB_ICONQUESTION = 0x20;
        public const int MB_OK = 0;
        public const int MB_SYSTEMMODAL = 0x1000;
        public const int MB_YESNO = 4;
        public const int MCHT_CALENDAR = 0x20000;
        public const int MCHT_CALENDARBK = 0x20000;
        public const int MCHT_CALENDARDATE = 0x20001;
        public const int MCHT_CALENDARDATENEXT = 0x1020001;
        public const int MCHT_CALENDARDATEPREV = 0x2020001;
        public const int MCHT_CALENDARDAY = 0x20002;
        public const int MCHT_CALENDARWEEKNUM = 0x20003;
        public const int MCHT_TITLE = 0x10000;
        public const int MCHT_TITLEBK = 0x10000;
        public const int MCHT_TITLEBTNNEXT = 0x1010003;
        public const int MCHT_TITLEBTNPREV = 0x2010003;
        public const int MCHT_TITLEMONTH = 0x10001;
        public const int MCHT_TITLEYEAR = 0x10002;
        public const int MCHT_TODAYLINK = 0x30000;
        public const int MCM_GETMAXTODAYWIDTH = 0x1015;
        public const int MCM_GETMINREQRECT = 0x1009;
        public const int MCM_GETMONTHRANGE = 0x1007;
        public const int MCM_GETTODAY = 0x100d;
        public const int MCM_HITTEST = 0x100e;
        public const int MCM_SETCOLOR = 0x100a;
        public const int MCM_SETFIRSTDAYOFWEEK = 0x100f;
        public const int MCM_SETMAXSELCOUNT = 0x1004;
        public const int MCM_SETMONTHDELTA = 0x1014;
        public const int MCM_SETRANGE = 0x1012;
        public const int MCM_SETSELRANGE = 0x1006;
        public const int MCM_SETTODAY = 0x100c;
        public const int MCN_GETDAYSTATE = -747;
        public const int MCN_SELCHANGE = -749;
        public const int MCN_SELECT = -746;
        public const int MCS_DAYSTATE = 1;
        public const int MCS_MULTISELECT = 2;
        public const int MCS_NOTODAY = 0x10;
        public const int MCS_NOTODAYCIRCLE = 8;
        public const int MCS_WEEKNUMBERS = 4;
        public const int MCSC_MONTHBK = 4;
        public const int MCSC_TEXT = 1;
        public const int MCSC_TITLEBK = 2;
        public const int MCSC_TITLETEXT = 3;
        public const int MCSC_TRAILINGTEXT = 5;
        public const int MDIS_ALLCHILDSTYLES = 1;
        public const int MDITILE_HORIZONTAL = 1;
        public const int MDITILE_SKIPDISABLED = 2;
        public const int MDITILE_VERTICAL = 0;
        public const int MEMBERID_NIL = -1;
        public const int MF_BYCOMMAND = 0;
        public const int MF_BYPOSITION = 0x400;
        public const int MF_ENABLED = 0;
        public const int MF_GRAYED = 1;
        public const int MF_POPUP = 0x10;
        public const int MF_SYSMENU = 0x2000;
        public const int MFS_DISABLED = 3;
        public const int MFT_MENUBREAK = 0x40;
        public const int MFT_RIGHTJUSTIFY = 0x4000;
        public const int MFT_RIGHTORDER = 0x2000;
        public const int MFT_SEPARATOR = 0x800;
        public const int MIIM_BITMAP = 0x80;
        public const int MIIM_DATA = 0x20;
        public const int MIIM_FTYPE = 0x100;
        public const int MIIM_ID = 2;
        public const int MIIM_STATE = 1;
        public const int MIIM_STRING = 0x40;
        public const int MIIM_SUBMENU = 4;
        public const int MIIM_TYPE = 0x10;
        public const int MK_CONTROL = 8;
        public const int MK_LBUTTON = 1;
        public const int MK_MBUTTON = 0x10;
        public const int MK_RBUTTON = 2;
        public const int MK_SHIFT = 4;
        public const int MM_ANISOTROPIC = 8;
        public const int MM_ISOTROPIC = 7;
        public const int MM_TEXT = 1;
        public const int MNC_EXECUTE = 2;
        public const int MNC_SELECT = 3;
        public const int MONITOR_DEFAULTTONEAREST = 2;
        public const int MONITOR_DEFAULTTONULL = 0;
        public const int MONITOR_DEFAULTTOPRIMARY = 1;
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int MOUSEEVENTF_ACTUAL = 0x10000;
        public const int MOUSEEVENTF_LEFTDOWN = 2;
        public const int MOUSEEVENTF_LEFTUP = 4;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
        public const int MOUSEEVENTF_MOVE = 1;
        public const int MOUSEEVENTF_RIGHTDOWN = 8;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;
        public const int MOUSEEVENTF_WHEEL = 0x800;
        public const int MOUSEEVENTF_XDOWN = 0x80;
        public const int MOUSEEVENTF_XUP = 0x100;
        public const int MSAA_MENU_SIG = -1441927155;
        public const int MUTZ_NOSAVEDFILECHECK = 1;
        public const int MWMO_ALERTABLE = 2;
        public const int MWMO_INPUTAVAILABLE = 4;
        public const int MWMO_WAITALL = 1;
        public const int NI_COMPOSITIONSTR = 0x15;
        public const int NO_ERROR = 0;
        public const uint NOTIFY_FOR_THIS_SESSION = 0;
        public const int NOTSRCCOPY = 0x330008;
        public const int NULL_BRUSH = 5;
        public static HandleRef NullHandleRef = new HandleRef(null, IntPtr.Zero);
        public const int OBJID_CLIENT = -4;
        public const int OFN_ALLOWMULTISELECT = 0x200;
        public const int OFN_CREATEPROMPT = 0x2000;
        public const int OFN_ENABLEHOOK = 0x20;
        public const int OFN_ENABLESIZING = 0x800000;
        public const int OFN_EXPLORER = 0x80000;
        public const int OFN_FILEMUSTEXIST = 0x1000;
        public const int OFN_HIDEREADONLY = 4;
        public const int OFN_NOCHANGEDIR = 8;
        public const int OFN_NODEREFERENCELINKS = 0x100000;
        public const int OFN_NOVALIDATE = 0x100;
        public const int OFN_OVERWRITEPROMPT = 2;
        public const int OFN_PATHMUSTEXIST = 0x800;
        public const int OFN_READONLY = 1;
        public const int OFN_USESHELLITEM = 0x1000000;
        public const int OLECONTF_EMBEDDINGS = 1;
        public const int OLECONTF_LINKS = 2;
        public const int OLECONTF_ONLYIFRUNNING = 0x10;
        public const int OLECONTF_ONLYUSER = 8;
        public const int OLECONTF_OTHERS = 4;
        public const int OLEIVERB_DISCARDUNDOSTATE = -6;
        public const int OLEIVERB_HIDE = -3;
        public const int OLEIVERB_INPLACEACTIVATE = -5;
        public const int OLEIVERB_PRIMARY = 0;
        public const int OLEIVERB_PROPERTIES = -7;
        public const int OLEIVERB_SHOW = -1;
        public const int OLEIVERB_UIACTIVATE = -4;
        public const int OLEMISC_ACTIVATEWHENVISIBLE = 0x100;
        public const int OLEMISC_ACTSLIKEBUTTON = 0x1000;
        public const int OLEMISC_INSIDEOUT = 0x80;
        public const int OLEMISC_RECOMPOSEONRESIZE = 1;
        public const int OLEMISC_SETCLIENTSITEFIRST = 0x20000;
        public const int OPAQUE = 2;
        public const int OPEN_EXISTING = 3;
        public const int PAGE_READONLY = 2;
        public const int PAGE_READWRITE = 4;
        public const int PATCOPY = 0xf00021;
        public const int PATINVERT = 0x5a0049;
        public const int PBM_SETBARCOLOR = 0x409;
        public const int PBM_SETBKCOLOR = 0x2001;
        public const int PBM_SETPOS = 0x402;
        public const int PBM_SETRANGE = 0x401;
        public const int PBM_SETRANGE32 = 0x406;
        public const int PBM_SETSTEP = 0x404;
        public const int PBT_APMPOWERSTATUSCHANGE = 10;
        public const int PBT_APMRESUMEAUTOMATIC = 0x12;
        public const int PBT_APMRESUMECRITICAL = 6;
        public const int PBT_APMRESUMESUSPEND = 7;
        public const int PBT_APMSUSPEND = 4;
        public const int PBT_POWERSETTINGCHANGE = 0x8013;
        public const int PD_ALLPAGES = 0;
        public const int PD_COLLATE = 0x10;
        public const int PD_CURRENTPAGE = 0x400000;
        public const int PD_DISABLEPRINTTOFILE = 0x80000;
        public const int PD_ENABLEPRINTHOOK = 0x1000;
        public const int PD_ENABLEPRINTTEMPLATE = 0x4000;
        public const int PD_ENABLEPRINTTEMPLATEHANDLE = 0x10000;
        public const int PD_ENABLESETUPHOOK = 0x2000;
        public const int PD_ENABLESETUPTEMPLATE = 0x8000;
        public const int PD_ENABLESETUPTEMPLATEHANDLE = 0x20000;
        public const int PD_EXCLUSIONFLAGS = 0x1000000;
        public const int PD_HIDEPRINTTOFILE = 0x100000;
        public const int PD_NOCURRENTPAGE = 0x800000;
        public const int PD_NONETWORKBUTTON = 0x200000;
        public const int PD_NOPAGENUMS = 8;
        public const int PD_NOSELECTION = 4;
        public const int PD_NOWARNING = 0x80;
        public const int PD_PAGENUMS = 2;
        public const int PD_PRINTSETUP = 0x40;
        public const int PD_PRINTTOFILE = 0x20;
        public const int PD_RETURNDC = 0x100;
        public const int PD_RETURNDEFAULT = 0x400;
        public const int PD_RETURNIC = 0x200;
        public const int PD_SELECTION = 1;
        public const int PD_SHOWHELP = 0x800;
        public const int PD_USEDEVMODECOPIES = 0x40000;
        public const int PD_USEDEVMODECOPIESANDCOLLATE = 0x40000;
        public const int PD_USELARGETEMPLATE = 0x10000000;
        public const int PDERR_CREATEICFAILURE = 0x100a;
        public const int PDERR_DEFAULTDIFFERENT = 0x100c;
        public const int PDERR_DNDMMISMATCH = 0x1009;
        public const int PDERR_GETDEVMODEFAIL = 0x1005;
        public const int PDERR_INITFAILURE = 0x1006;
        public const int PDERR_LOADDRVFAILURE = 0x1004;
        public const int PDERR_NODEFAULTPRN = 0x1008;
        public const int PDERR_NODEVICES = 0x1007;
        public const int PDERR_PARSEFAILURE = 0x1002;
        public const int PDERR_PRINTERNOTFOUND = 0x100b;
        public const int PDERR_RETDEFFAILURE = 0x1003;
        public const int PDERR_SETUPFAILURE = 0x1001;
        public const int PLANES = 14;
        public const int PM_NOREMOVE = 0;
        public const int PM_NOYIELD = 2;
        public const int PM_QS_INPUT = 0x70000;
        public const int PM_QS_PAINT = 0x200000;
        public const int PM_QS_POSTMESSAGE = 0x980000;
        public const int PM_QS_SENDMESSAGE = 0x400000;
        public const int PM_REMOVE = 1;
        public const int PRF_CHECKVISIBLE = 1;
        public const int PRF_CHILDREN = 0x10;
        public const int PRF_CLIENT = 4;
        public const int PRF_ERASEBKGND = 8;
        public const int PRF_NONCLIENT = 2;
        public const uint PROFILE_READ = 1;
        public const int PS_DOT = 2;
        public const int PS_SOLID = 0;
        public const int PSD_DISABLEMARGINS = 0x10;
        public const int PSD_DISABLEORIENTATION = 0x100;
        public const int PSD_DISABLEPAPER = 0x200;
        public const int PSD_DISABLEPRINTER = 0x20;
        public const int PSD_ENABLEPAGESETUPHOOK = 0x2000;
        public const int PSD_INHUNDREDTHSOFMILLIMETERS = 8;
        public const int PSD_MARGINS = 2;
        public const int PSD_MINMARGINS = 1;
        public const int PSD_NONETWORKBUTTON = 0x200000;
        public const int PSD_SHOWHELP = 0x800;
        public const int PSM_SETFINISHTEXTA = 0x473;
        public const int PSM_SETFINISHTEXTW = 0x479;
        public const int PSM_SETTITLEA = 0x46f;
        public const int PSM_SETTITLEW = 0x478;
        public const int PUAF_NOUI = 1;
        public const int QS_ALLEVENTS = 0xbf;
        public const int QS_ALLINPUT = 0xff;
        public const int QS_ALLPOSTMESSAGE = 0x100;
        public const int QS_EVENT = 0x2000;
        public const int QS_HOTKEY = 0x80;
        public const int QS_INPUT = 7;
        public const int QS_KEY = 1;
        public const int QS_MOUSE = 6;
        public const int QS_MOUSEBUTTON = 4;
        public const int QS_MOUSEMOVE = 2;
        public const int QS_PAINT = 0x20;
        public const int QS_POSTMESSAGE = 8;
        public const int QS_SENDMESSAGE = 0x40;
        public const int QS_TIMER = 0x10;
        public const int RDW_ALLCHILDREN = 0x80;
        public const int RDW_INVALIDATE = 1;
        public const uint READ_CONTROL = 0x20000;
        public const uint RIDI_DEVICEINFO = 0x2000000b;
        public const uint RIM_TYPEHID = 2;
        public const int S_FALSE = 1;
        public const int S_OK = 0;
        public const int SB_BOTTOM = 7;
        public const int SB_CTL = 2;
        public const int SB_ENDSCROLL = 8;
        public const int SB_GETRECT = 0x40a;
        public const int SB_GETTEXTA = 0x402;
        public const int SB_GETTEXTLENGTHA = 0x403;
        public const int SB_GETTEXTLENGTHW = 0x40c;
        public const int SB_GETTEXTW = 0x40d;
        public const int SB_GETTIPTEXTA = 0x412;
        public const int SB_GETTIPTEXTW = 0x413;
        public const int SB_HORZ = 0;
        public const int SB_LEFT = 6;
        public const int SB_LINEDOWN = 1;
        public const int SB_LINELEFT = 0;
        public const int SB_LINERIGHT = 1;
        public const int SB_LINEUP = 0;
        public const int SB_PAGEDOWN = 3;
        public const int SB_PAGELEFT = 2;
        public const int SB_PAGERIGHT = 3;
        public const int SB_PAGEUP = 2;
        public const int SB_RIGHT = 7;
        public const int SB_SETICON = 0x40f;
        public const int SB_SETPARTS = 0x404;
        public const int SB_SETTEXTA = 0x401;
        public const int SB_SETTEXTW = 0x40b;
        public const int SB_SETTIPTEXTA = 0x410;
        public const int SB_SETTIPTEXTW = 0x411;
        public const int SB_SIMPLE = 0x409;
        public const int SB_THUMBPOSITION = 4;
        public const int SB_THUMBTRACK = 5;
        public const int SB_TOP = 6;
        public const int SB_VERT = 1;
        public const int SBARS_SIZEGRIP = 0x100;
        public const int SBS_HORZ = 0;
        public const int SBS_VERT = 1;
        public const int SBT_NOBORDERS = 0x100;
        public const int SBT_OWNERDRAW = 0x1000;
        public const int SBT_POPOUT = 0x200;
        public const int SBT_RTLREADING = 0x400;
        public const int SC_CLOSE = 0xf060;
        public const int SC_KEYMENU = 0xf100;
        public const int SC_MAXIMIZE = 0xf030;
        public const int SC_MINIMIZE = 0xf020;
        public const int SC_MOUSEMOVE = 0xf012;
        public const int SC_MOVE = 0xf010;
        public const int SC_RESTORE = 0xf120;
        public const int SC_SIZE = 0xf000;
        public const int SECTION_MAP_READ = 4;
        public const int SET_FEATURE_ON_PROCESS = 2;
        public const int SHGFP_TYPE_CURRENT = 0;
        public const int SIF_ALL = 0x17;
        public const int SIF_PAGE = 2;
        public const int SIF_POS = 4;
        public const int SIF_RANGE = 1;
        public const int SIF_TRACKPOS = 0x10;
        public const int SIZE_MAXIMIZED = 2;
        public const int SIZE_MINIMIZED = 1;
        public const int SIZE_RESTORED = 0;
        public const int SORT_DEFAULT = 0;
        public const uint SPECIFIC_RIGHTS_ALL = 0xffff;
        public const int SPI_GETACTIVEWINDOWTRACKING = 0x1000;
        public const int SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;
        public const int SPI_GETANIMATION = 0x48;
        public const int SPI_GETBORDER = 5;
        public const int SPI_GETCARETWIDTH = 0x2006;
        public const int SPI_GETCLIENTAREAANIMATION = 0x1042;
        public const int SPI_GETCOMBOBOXANIMATION = 0x1004;
        public const int SPI_GETCURSORSHADOW = 0x101a;
        public const int SPI_GETDEFAULTINPUTLANG = 0x59;
        public const int SPI_GETDRAGFULLWINDOWS = 0x26;
        public const int SPI_GETDROPSHADOW = 0x1024;
        public const int SPI_GETFLATMENU = 0x1022;
        public const int SPI_GETFOCUSBORDERHEIGHT = 0x2010;
        public const int SPI_GETFOCUSBORDERWIDTH = 0x200e;
        public const int SPI_GETFONTSMOOTHING = 0x4a;
        public const int SPI_GETFONTSMOOTHINGCONTRAST = 0x200c;
        public const int SPI_GETFONTSMOOTHINGTYPE = 0x200a;
        public const int SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;
        public const int SPI_GETGRADIENTCAPTIONS = 0x1008;
        public const int SPI_GETHIGHCONTRAST = 0x42;
        public const int SPI_GETHOTTRACKING = 0x100e;
        public const int SPI_GETICONMETRICS = 0x2d;
        public const int SPI_GETICONTITLELOGFONT = 0x1f;
        public const int SPI_GETICONTITLEWRAP = 0x19;
        public const int SPI_GETKEYBOARDCUES = 0x100a;
        public const int SPI_GETKEYBOARDDELAY = 0x16;
        public const int SPI_GETKEYBOARDPREF = 0x44;
        public const int SPI_GETKEYBOARDSPEED = 10;
        public const int SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;
        public const int SPI_GETMENUANIMATION = 0x1002;
        public const int SPI_GETMENUDROPALIGNMENT = 0x1b;
        public const int SPI_GETMENUFADE = 0x1012;
        public const int SPI_GETMENUSHOWDELAY = 0x6a;
        public const int SPI_GETMOUSEHOVERHEIGHT = 100;
        public const int SPI_GETMOUSEHOVERTIME = 0x66;
        public const int SPI_GETMOUSEHOVERWIDTH = 0x62;
        public const int SPI_GETMOUSESPEED = 0x70;
        public const int SPI_GETMOUSEVANISH = 0x1020;
        public const int SPI_GETNONCLIENTMETRICS = 0x29;
        public const int SPI_GETSELECTIONFADE = 0x1014;
        public const int SPI_GETSNAPTODEFBUTTON = 0x5f;
        public const int SPI_GETSTYLUSHOTTRACKING = 0x1010;
        public const int SPI_GETTOOLTIPANIMATION = 0x1016;
        public const int SPI_GETTOOLTIPFADE = 0x1018;
        public const int SPI_GETUIEFFECTS = 0x103e;
        public const int SPI_GETWHEELSCROLLLINES = 0x68;
        public const int SPI_GETWORKAREA = 0x30;
        public const int SPI_ICONHORIZONTALSPACING = 13;
        public const int SPI_ICONVERTICALSPACING = 0x18;
        public const int SPI_SETANIMATION = 0x49;
        public const int SPI_SETBORDER = 6;
        public const int SPI_SETCARETWIDTH = 0x2007;
        public const int SPI_SETCLIENTAREAANIMATION = 0x1043;
        public const int SPI_SETCOMBOBOXANIMATION = 0x1005;
        public const int SPI_SETCURSORSHADOW = 0x101b;
        public const int SPI_SETDISPLAYCLEARTYPELEVEL = 0x2019;
        public const int SPI_SETDISPLAYGAMMA = 0x2017;
        public const int SPI_SETDISPLAYPIXELSTRUCTURE = 0x2015;
        public const int SPI_SETDISPLAYTEXTCONTRASTLEVEL = 0x201b;
        public const int SPI_SETDRAGFULLWINDOWS = 0x25;
        public const int SPI_SETDRAGHEIGHT = 0x4d;
        public const int SPI_SETDRAGWIDTH = 0x4c;
        public const int SPI_SETDROPSHADOW = 0x1025;
        public const int SPI_SETFLATMENU = 0x1023;
        public const int SPI_SETFOCUSBORDERHEIGHT = 0x2011;
        public const int SPI_SETFOCUSBORDERWIDTH = 0x200f;
        public const int SPI_SETFONTSMOOTHING = 0x4b;
        public const int SPI_SETFONTSMOOTHINGCONTRAST = 0x200d;
        public const int SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;
        public const int SPI_SETFONTSMOOTHINGTYPE = 0x200b;
        public const int SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;
        public const int SPI_SETGRADIENTCAPTIONS = 0x1009;
        public const int SPI_SETHIGHCONTRAST = 0x43;
        public const int SPI_SETHOTTRACKING = 0x100f;
        public const int SPI_SETICONMETRICS = 0x2e;
        public const int SPI_SETKEYBOARDCUES = 0x100b;
        public const int SPI_SETKEYBOARDDELAY = 0x17;
        public const int SPI_SETKEYBOARDPREF = 0x45;
        public const int SPI_SETKEYBOARDSPEED = 11;
        public const int SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;
        public const int SPI_SETMENUANIMATION = 0x1003;
        public const int SPI_SETMENUDROPALIGNMENT = 0x1c;
        public const int SPI_SETMENUFADE = 0x1013;
        public const int SPI_SETMENUSHOWDELAY = 0x6b;
        public const int SPI_SETMOUSEBUTTONSWAP = 0x21;
        public const int SPI_SETMOUSEHOVERHEIGHT = 0x65;
        public const int SPI_SETMOUSEHOVERTIME = 0x67;
        public const int SPI_SETMOUSEHOVERWIDTH = 0x63;
        public const int SPI_SETMOUSEVANISH = 0x1021;
        public const int SPI_SETNONCLIENTMETRICS = 0x2a;
        public const int SPI_SETPENWINDOWS = 0x31;
        public const int SPI_SETSELECTIONFADE = 0x1015;
        public const int SPI_SETSHOWSOUNDS = 0x39;
        public const int SPI_SETSNAPTODEFBUTTON = 0x60;
        public const int SPI_SETSTYLUSHOTTRACKING = 0x1011;
        public const int SPI_SETTOOLTIPANIMATION = 0x1017;
        public const int SPI_SETTOOLTIPFADE = 0x1019;
        public const int SPI_SETUIEFFECTS = 0x103f;
        public const int SPI_SETWHEELSCROLLLINES = 0x69;
        public const int SPI_SETWORKAREA = 0x2f;
        public const int SRCAND = 0x8800c6;
        public const int SRCCOPY = 0xcc0020;
        public const int SRCPAINT = 0xee0086;
        public const int SS_CENTER = 1;
        public const int SS_LEFT = 0;
        public const int SS_NOPREFIX = 0x80;
        public const int SS_OWNERDRAW = 13;
        public const int SS_RIGHT = 2;
        public const int SS_SUNKEN = 0x1000;
        public const uint STANDARD_RIGHTS_ALL = 0x1f0000;
        public const uint STANDARD_RIGHTS_EXECUTE = 0x20000;
        public const uint STANDARD_RIGHTS_READ = 0x20000;
        public const uint STANDARD_RIGHTS_REQUIRED = 0xf0000;
        public const uint STANDARD_RIGHTS_WRITE = 0x20000;
        public const int STARTF_USESHOWWINDOW = 1;
        public const int STATFLAG_DEFAULT = 0;
        public const int STATFLAG_NONAME = 1;
        public const int STATFLAG_NOOPEN = 2;
        public const int stc4 = 0x443;
        public const int STG_E_CANTSAVE = -2147286781;
        public const int STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4;
        public const int STGC_DEFAULT = 0;
        public const int STGC_ONLYIFCURRENT = 2;
        public const int STGC_OVERWRITE = 1;
        public const int STGM_CONVERT = 0x20000;
        public const int STGM_CREATE = 0x1000;
        public const int STGM_DELETEONRELEASE = 0x4000000;
        public const int STGM_READ = 0;
        public const int STGM_READWRITE = 2;
        public const int STGM_SHARE_EXCLUSIVE = 0x10;
        public const int STGM_TRANSACTED = 0x10000;
        public const int STGM_WRITE = 1;
        public const int STGTY_LOCKBYTES = 3;
        public const int STGTY_PROPERTY = 4;
        public const int STGTY_STORAGE = 1;
        public const int STGTY_STREAM = 2;
        public const int STREAM_SEEK_CUR = 1;
        public const int STREAM_SEEK_END = 2;
        public const int STREAM_SEEK_SET = 0;
        public const int SUBLANG_DEFAULT = 1;
        public const int SW_ERASE = 4;
        public const int SW_HIDE = 0;
        public const int SW_INVALIDATE = 2;
        public const int SW_MAX = 10;
        public const int SW_MAXIMIZE = 3;
        public const int SW_MINIMIZE = 6;
        public const int SW_NORMAL = 1;
        public const int SW_PARENTCLOSING = 1;
        public const int SW_PARENTOPENING = 3;
        public const int SW_RESTORE = 9;
        public const int SW_SCROLLCHILDREN = 1;
        public const int SW_SHOW = 5;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMINNOACTIVE = 7;
        public const int SW_SHOWNA = 8;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SMOOTHSCROLL = 0x10;
        public const int SWP_ASYNCWINDOWPOS = 0x4000;
        public const int SWP_DEFERERASE = 0x2000;
        public const int SWP_DRAWFRAME = 0x20;
        public const int SWP_FRAMECHANGED = 0x20;
        public const int SWP_HIDEWINDOW = 0x80;
        public const int SWP_NOACTIVATE = 0x10;
        public const int SWP_NOCOPYBITS = 0x100;
        public const int SWP_NOMOVE = 2;
        public const int SWP_NOOWNERZORDER = 0x200;
        public const int SWP_NOREDRAW = 8;
        public const int SWP_NOREPOSITION = 0x200;
        public const int SWP_NOSENDCHANGING = 0x400;
        public const int SWP_NOSIZE = 1;
        public const int SWP_NOZORDER = 4;
        public const int SWP_SHOWWINDOW = 0x40;
        public const uint SYNCHRONIZE = 0x100000;
        public const int TB_ADDBUTTONSA = 0x414;
        public const int TB_ADDBUTTONSW = 0x444;
        public const int TB_ADDSTRINGA = 0x41c;
        public const int TB_ADDSTRINGW = 0x44d;
        public const int TB_AUTOSIZE = 0x421;
        public const int TB_BOTTOM = 7;
        public const int TB_BUTTONSTRUCTSIZE = 0x41e;
        public const int TB_DELETEBUTTON = 0x416;
        public const int TB_ENABLEBUTTON = 0x401;
        public const int TB_ENDTRACK = 8;
        public const int TB_GETBUTTON = 0x417;
        public const int TB_GETBUTTONINFOA = 0x441;
        public const int TB_GETBUTTONINFOW = 0x43f;
        public const int TB_GETBUTTONSIZE = 0x43a;
        public const int TB_GETBUTTONTEXTA = 0x42d;
        public const int TB_GETBUTTONTEXTW = 0x44b;
        public const int TB_GETRECT = 0x433;
        public const int TB_GETROWS = 0x428;
        public const int TB_GETTOOLTIPS = 0x423;
        public const int TB_INSERTBUTTONA = 0x415;
        public const int TB_INSERTBUTTONW = 0x443;
        public const int TB_ISBUTTONCHECKED = 0x40a;
        public const int TB_ISBUTTONINDETERMINATE = 0x40d;
        public const int TB_LINEDOWN = 1;
        public const int TB_LINEUP = 0;
        public const int TB_MAPACCELERATORA = 0x44e;
        public const int TB_MAPACCELERATORW = 0x45a;
        public const int TB_PAGEDOWN = 3;
        public const int TB_PAGEUP = 2;
        public const int TB_SAVERESTOREA = 0x41a;
        public const int TB_SAVERESTOREW = 0x44c;
        public const int TB_SETBUTTONINFOA = 0x442;
        public const int TB_SETBUTTONINFOW = 0x440;
        public const int TB_SETBUTTONSIZE = 0x41f;
        public const int TB_SETEXTENDEDSTYLE = 0x454;
        public const int TB_SETIMAGELIST = 0x430;
        public const int TB_SETTOOLTIPS = 0x424;
        public const int TB_THUMBPOSITION = 4;
        public const int TB_THUMBTRACK = 5;
        public const int TB_TOP = 6;
        public const int TBIF_COMMAND = 0x20;
        public const int TBIF_IMAGE = 1;
        public const int TBIF_SIZE = 0x40;
        public const int TBIF_STATE = 4;
        public const int TBIF_STYLE = 8;
        public const int TBIF_TEXT = 2;
        public const int TBM_GETPOS = 0x400;
        public const int TBM_SETLINESIZE = 0x417;
        public const int TBM_SETPAGESIZE = 0x415;
        public const int TBM_SETPOS = 0x405;
        public const int TBM_SETRANGE = 0x406;
        public const int TBM_SETRANGEMAX = 0x408;
        public const int TBM_SETRANGEMIN = 0x407;
        public const int TBM_SETTIC = 0x404;
        public const int TBM_SETTICFREQ = 0x414;
        public const int TBN_DROPDOWN = -710;
        public const int TBN_GETBUTTONINFOA = -700;
        public const int TBN_GETBUTTONINFOW = -720;
        public const int TBN_GETDISPINFOA = -716;
        public const int TBN_GETDISPINFOW = -717;
        public const int TBN_GETINFOTIPA = -718;
        public const int TBN_GETINFOTIPW = -719;
        public const int TBN_HOTITEMCHANGE = -713;
        public const int TBN_QUERYINSERT = -706;
        public const int TBS_AUTOTICKS = 1;
        public const int TBS_BOTH = 8;
        public const int TBS_BOTTOM = 0;
        public const int TBS_NOTICKS = 0x10;
        public const int TBS_TOP = 4;
        public const int TBS_VERT = 2;
        public const int TBSTATE_CHECKED = 1;
        public const int TBSTATE_ENABLED = 4;
        public const int TBSTATE_HIDDEN = 8;
        public const int TBSTATE_INDETERMINATE = 0x10;
        public const int TBSTYLE_BUTTON = 0;
        public const int TBSTYLE_CHECK = 2;
        public const int TBSTYLE_DROPDOWN = 8;
        public const int TBSTYLE_EX_DRAWDDARROWS = 1;
        public const int TBSTYLE_FLAT = 0x800;
        public const int TBSTYLE_LIST = 0x1000;
        public const int TBSTYLE_SEP = 1;
        public const int TBSTYLE_TOOLTIPS = 0x100;
        public const int TBSTYLE_WRAPPABLE = 0x200;
        public const int TCIF_IMAGE = 2;
        public const int TCIF_TEXT = 1;
        public const int TCM_ADJUSTRECT = 0x1328;
        public const int TCM_DELETEALLITEMS = 0x1309;
        public const int TCM_DELETEITEM = 0x1308;
        public const int TCM_GETCURSEL = 0x130b;
        public const int TCM_GETITEMA = 0x1305;
        public const int TCM_GETITEMRECT = 0x130a;
        public const int TCM_GETITEMW = 0x133c;
        public const int TCM_GETROWCOUNT = 0x132c;
        public const int TCM_GETTOOLTIPS = 0x132d;
        public const int TCM_INSERTITEMA = 0x1307;
        public const int TCM_INSERTITEMW = 0x133e;
        public const int TCM_SETCURSEL = 0x130c;
        public const int TCM_SETIMAGELIST = 0x1303;
        public const int TCM_SETITEMA = 0x1306;
        public const int TCM_SETITEMSIZE = 0x1329;
        public const int TCM_SETITEMW = 0x133d;
        public const int TCM_SETPADDING = 0x132b;
        public const int TCM_SETTOOLTIPS = 0x132e;
        public const int TCN_SELCHANGE = -551;
        public const int TCN_SELCHANGING = -552;
        public const int TCS_BOTTOM = 2;
        public const int TCS_BUTTONS = 0x100;
        public const int TCS_FIXEDWIDTH = 0x400;
        public const int TCS_FLATBUTTONS = 8;
        public const int TCS_HOTTRACK = 0x40;
        public const int TCS_MULTILINE = 0x200;
        public const int TCS_OWNERDRAWFIXED = 0x2000;
        public const int TCS_RAGGEDRIGHT = 0x800;
        public const int TCS_RIGHT = 2;
        public const int TCS_RIGHTJUSTIFY = 0;
        public const int TCS_TABS = 0;
        public const int TCS_TOOLTIPS = 0x4000;
        public const int TCS_VERTICAL = 0x80;
        public const int TME_CANCEL = -2147483648;
        public const int TME_HOVER = 1;
        public const int TME_LEAVE = 2;
        public const int TPM_LEFTALIGN = 0;
        public const int TPM_LEFTBUTTON = 0;
        public const int TPM_RIGHTALIGN = 8;
        public const int TPM_RIGHTBUTTON = 2;
        public const int TPM_VERTICAL = 0x40;
        public const int TRANSPARENT = 1;
        public const int TTDT_AUTOMATIC = 0;
        public const int TTDT_AUTOPOP = 2;
        public const int TTDT_INITIAL = 3;
        public const int TTDT_RESHOW = 1;
        public const int TTF_ABSOLUTE = 0x80;
        public const int TTF_CENTERTIP = 2;
        public const int TTF_IDISHWND = 1;
        public const int TTF_RTLREADING = 4;
        public const int TTF_SUBCLASS = 0x10;
        public const int TTF_TRACK = 0x20;
        public const int TTF_TRANSPARENT = 0x100;
        public const int TTI_WARNING = 2;
        public const int TTM_ACTIVATE = 0x401;
        public const int TTM_ADDTOOLA = 0x404;
        public const int TTM_ADDTOOLW = 0x432;
        public const int TTM_ADJUSTRECT = 0x41f;
        public const int TTM_DELTOOLA = 0x405;
        public const int TTM_DELTOOLW = 0x433;
        public const int TTM_ENUMTOOLSA = 0x40e;
        public const int TTM_ENUMTOOLSW = 0x43a;
        public const int TTM_GETCURRENTTOOLA = 0x40f;
        public const int TTM_GETCURRENTTOOLW = 0x43b;
        public const int TTM_GETDELAYTIME = 0x415;
        public const int TTM_GETTEXTA = 0x40b;
        public const int TTM_GETTEXTW = 0x438;
        public const int TTM_GETTIPBKCOLOR = 0x416;
        public const int TTM_GETTIPTEXTCOLOR = 0x417;
        public const int TTM_GETTOOLINFOA = 0x408;
        public const int TTM_GETTOOLINFOW = 0x435;
        public const int TTM_HITTESTA = 0x40a;
        public const int TTM_HITTESTW = 0x437;
        public const int TTM_NEWTOOLRECTA = 0x406;
        public const int TTM_NEWTOOLRECTW = 0x434;
        public const int TTM_POP = 0x41c;
        public const int TTM_RELAYEVENT = 0x407;
        public const int TTM_SETDELAYTIME = 0x403;
        public const int TTM_SETMAXTIPWIDTH = 0x418;
        public const int TTM_SETTIPBKCOLOR = 0x413;
        public const int TTM_SETTIPTEXTCOLOR = 0x414;
        public const int TTM_SETTITLEA = 0x420;
        public const int TTM_SETTITLEW = 0x421;
        public const int TTM_SETTOOLINFOA = 0x409;
        public const int TTM_SETTOOLINFOW = 0x436;
        public const int TTM_TRACKACTIVATE = 0x411;
        public const int TTM_TRACKPOSITION = 0x412;
        public const int TTM_UPDATE = 0x41d;
        public const int TTM_UPDATETIPTEXTA = 0x40c;
        public const int TTM_UPDATETIPTEXTW = 0x439;
        public const int TTM_WINDOWFROMPOINT = 0x410;
        public const int TTN_GETDISPINFOA = -520;
        public const int TTN_GETDISPINFOW = -530;
        public const int TTN_NEEDTEXTA = -520;
        public const int TTN_NEEDTEXTW = -530;
        public const int TTN_POP = -522;
        public const int TTN_SHOW = -521;
        public const int TTS_ALWAYSTIP = 1;
        public const int TTS_BALLOON = 0x40;
        public const int TTS_NOANIMATE = 0x10;
        public const int TTS_NOFADE = 0x20;
        public const int TTS_NOPREFIX = 2;
        public const int TV_FIRST = 0x1100;
        public const int TVC_BYKEYBOARD = 2;
        public const int TVC_BYMOUSE = 1;
        public const int TVC_UNKNOWN = 0;
        public const int TVE_COLLAPSE = 1;
        public const int TVE_EXPAND = 2;
        public const int TVGN_CARET = 9;
        public const int TVGN_FIRSTVISIBLE = 5;
        public const int TVGN_NEXT = 1;
        public const int TVGN_NEXTVISIBLE = 6;
        public const int TVGN_PREVIOUS = 2;
        public const int TVGN_PREVIOUSVISIBLE = 7;
        public const int TVI_FIRST = -65535;
        public const int TVI_ROOT = -65536;
        public const int TVIF_HANDLE = 0x10;
        public const int TVIF_IMAGE = 2;
        public const int TVIF_PARAM = 4;
        public const int TVIF_SELECTEDIMAGE = 0x20;
        public const int TVIF_STATE = 8;
        public const int TVIF_TEXT = 1;
        public const int TVIS_EXPANDED = 0x20;
        public const int TVIS_EXPANDEDONCE = 0x40;
        public const int TVIS_SELECTED = 2;
        public const int TVIS_STATEIMAGEMASK = 0xf000;
        public const int TVM_DELETEITEM = 0x1101;
        public const int TVM_EDITLABELA = 0x110e;
        public const int TVM_EDITLABELW = 0x1141;
        public const int TVM_ENDEDITLABELNOW = 0x1116;
        public const int TVM_ENSUREVISIBLE = 0x1114;
        public const int TVM_EXPAND = 0x1102;
        public const int TVM_GETEDITCONTROL = 0x110f;
        public const int TVM_GETINDENT = 0x1106;
        public const int TVM_GETISEARCHSTRINGA = 0x1117;
        public const int TVM_GETISEARCHSTRINGW = 0x1140;
        public const int TVM_GETITEMA = 0x110c;
        public const int TVM_GETITEMHEIGHT = 0x111c;
        public const int TVM_GETITEMRECT = 0x1104;
        public const int TVM_GETITEMW = 0x113e;
        public const int TVM_GETLINECOLOR = 0x1129;
        public const int TVM_GETNEXTITEM = 0x110a;
        public const int TVM_GETVISIBLECOUNT = 0x1110;
        public const int TVM_HITTEST = 0x1111;
        public const int TVM_INSERTITEMA = 0x1100;
        public const int TVM_INSERTITEMW = 0x1132;
        public const int TVM_SELECTITEM = 0x110b;
        public const int TVM_SETBKCOLOR = 0x111d;
        public const int TVM_SETIMAGELIST = 0x1109;
        public const int TVM_SETINDENT = 0x1107;
        public const int TVM_SETITEMA = 0x110d;
        public const int TVM_SETITEMHEIGHT = 0x111b;
        public const int TVM_SETITEMW = 0x113f;
        public const int TVM_SETLINECOLOR = 0x1128;
        public const int TVM_SETTEXTCOLOR = 0x111e;
        public const int TVM_SETTOOLTIPS = 0x1118;
        public const int TVM_SORTCHILDRENCB = 0x1115;
        public const int TVN_BEGINDRAGA = -407;
        public const int TVN_BEGINDRAGW = -456;
        public const int TVN_BEGINLABELEDITA = -410;
        public const int TVN_BEGINLABELEDITW = -459;
        public const int TVN_BEGINRDRAGA = -408;
        public const int TVN_BEGINRDRAGW = -457;
        public const int TVN_ENDLABELEDITA = -411;
        public const int TVN_ENDLABELEDITW = -460;
        public const int TVN_GETDISPINFOA = -403;
        public const int TVN_GETDISPINFOW = -452;
        public const int TVN_GETINFOTIPA = -413;
        public const int TVN_GETINFOTIPW = -414;
        public const int TVN_ITEMEXPANDEDA = -406;
        public const int TVN_ITEMEXPANDEDW = -455;
        public const int TVN_ITEMEXPANDINGA = -405;
        public const int TVN_ITEMEXPANDINGW = -454;
        public const int TVN_SELCHANGEDA = -402;
        public const int TVN_SELCHANGEDW = -451;
        public const int TVN_SELCHANGINGA = -401;
        public const int TVN_SELCHANGINGW = -450;
        public const int TVN_SETDISPINFOA = -404;
        public const int TVN_SETDISPINFOW = -453;
        public const int TVS_CHECKBOXES = 0x100;
        public const int TVS_EDITLABELS = 8;
        public const int TVS_FULLROWSELECT = 0x1000;
        public const int TVS_HASBUTTONS = 1;
        public const int TVS_HASLINES = 2;
        public const int TVS_INFOTIP = 0x800;
        public const int TVS_LINESATROOT = 4;
        public const int TVS_NONEVENHEIGHT = 0x4000;
        public const int TVS_NOTOOLTIPS = 0x80;
        public const int TVS_RTLREADING = 0x40;
        public const int TVS_SHOWSELALWAYS = 0x20;
        public const int TVS_TRACKSELECT = 0x200;
        public const int TVSIL_STATE = 2;
        public const int TYMED_ENHMF = 0x40;
        public const int TYMED_FILE = 2;
        public const int TYMED_GDI = 0x10;
        public const int TYMED_HGLOBAL = 1;
        public const int TYMED_ISTORAGE = 8;
        public const int TYMED_ISTREAM = 4;
        public const int TYMED_MFPICT = 0x20;
        public const int TYMED_NULL = 0;
        public const int UIS_CLEAR = 2;
        public const int UIS_INITIALIZE = 3;
        public const int UIS_SET = 1;
        public const int UISF_ACTIVE = 4;
        public const int UISF_HIDEACCEL = 2;
        public const int UISF_HIDEFOCUS = 1;
        public const int ULW_ALPHA = 2;
        public const int ULW_COLORKEY = 1;
        public const int ULW_OPAQUE = 4;
        public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x2101;
        public const byte URLPOLICY_ALLOW = 0;
        public const byte URLPOLICY_DISALLOW = 3;
        public const byte URLPOLICY_QUERY = 1;
        public const int URLZONE_INTERNET = 3;
        public const int URLZONE_INTRANET = 1;
        public const int URLZONE_LOCAL_MACHINE = 0;
        public const int URLZONE_TRUSTED = 2;
        public const int URLZONE_UNTRUSTED = 4;
        public const int VK_0 = 0x30;
        public const int VK_1 = 0x31;
        public const int VK_2 = 50;
        public const int VK_3 = 0x33;
        public const int VK_4 = 0x34;
        public const int VK_5 = 0x35;
        public const int VK_6 = 0x36;
        public const int VK_7 = 0x37;
        public const int VK_8 = 0x38;
        public const int VK_9 = 0x39;
        public const int VK_A = 0x41;
        public const int VK_ACCEPT = 30;
        public const int VK_ADD = 0x6b;
        public const int VK_APPS = 0x5d;
        public const int VK_ATTN = 0xf6;
        public const int VK_B = 0x42;
        public const int VK_BACK = 8;
        public const int VK_BROWSER_BACK = 0xa6;
        public const int VK_BROWSER_FAVORITES = 0xab;
        public const int VK_BROWSER_FORWARD = 0xa7;
        public const int VK_BROWSER_HOME = 0xac;
        public const int VK_BROWSER_REFRESH = 0xa8;
        public const int VK_BROWSER_SEARCH = 170;
        public const int VK_BROWSER_STOP = 0xa9;
        public const int VK_C = 0x43;
        public const int VK_C1 = 0xc1;
        public const int VK_C2 = 0xc2;
        public const int VK_CANCEL = 3;
        public const int VK_CAPITAL = 20;
        public const int VK_CLEAR = 12;
        public const int VK_CONTROL = 0x11;
        public const int VK_CONVERT = 0x1c;
        public const int VK_CRSEL = 0xf7;
        public const int VK_D = 0x44;
        public const int VK_DECIMAL = 110;
        public const int VK_DELETE = 0x2e;
        public const int VK_DIVIDE = 0x6f;
        public const int VK_DOWN = 40;
        public const int VK_E = 0x45;
        public const int VK_END = 0x23;
        public const int VK_EREOF = 0xf9;
        public const int VK_ESCAPE = 0x1b;
        public const int VK_EXECUTE = 0x2b;
        public const int VK_EXSEL = 0xf8;
        public const int VK_F = 70;
        public const int VK_F1 = 0x70;
        public const int VK_F10 = 0x79;
        public const int VK_F11 = 0x7a;
        public const int VK_F12 = 0x7b;
        public const int VK_F13 = 0x7c;
        public const int VK_F14 = 0x7d;
        public const int VK_F15 = 0x7e;
        public const int VK_F16 = 0x7f;
        public const int VK_F17 = 0x80;
        public const int VK_F18 = 0x81;
        public const int VK_F19 = 130;
        public const int VK_F2 = 0x71;
        public const int VK_F20 = 0x83;
        public const int VK_F21 = 0x84;
        public const int VK_F22 = 0x85;
        public const int VK_F23 = 0x86;
        public const int VK_F24 = 0x87;
        public const int VK_F3 = 0x72;
        public const int VK_F4 = 0x73;
        public const int VK_F5 = 0x74;
        public const int VK_F6 = 0x75;
        public const int VK_F7 = 0x76;
        public const int VK_F8 = 0x77;
        public const int VK_F9 = 120;
        public const int VK_FINAL = 0x18;
        public const int VK_G = 0x47;
        public const int VK_H = 0x48;
        public const int VK_HANGEUL = 0x15;
        public const int VK_HANGUL = 0x15;
        public const int VK_HANJA = 0x19;
        public const int VK_HELP = 0x2f;
        public const int VK_HOME = 0x24;
        public const int VK_I = 0x49;
        public const int VK_INSERT = 0x2d;
        public const int VK_J = 0x4a;
        public const int VK_JUNJA = 0x17;
        public const int VK_K = 0x4b;
        public const int VK_KANA = 0x15;
        public const int VK_KANJI = 0x19;
        public const int VK_L = 0x4c;
        public const int VK_LAUNCH_APP1 = 0xb6;
        public const int VK_LAUNCH_APP2 = 0xb7;
        public const int VK_LAUNCH_MAIL = 180;
        public const int VK_LAUNCH_MEDIA_SELECT = 0xb5;
        public const int VK_LBUTTON = 1;
        public const int VK_LCONTROL = 0xa2;
        public const int VK_LEFT = 0x25;
        public const int VK_LMENU = 0xa4;
        public const int VK_LSHIFT = 160;
        public const int VK_LWIN = 0x5b;
        public const int VK_M = 0x4d;
        public const int VK_MBUTTON = 4;
        public const int VK_MEDIA_NEXT_TRACK = 0xb0;
        public const int VK_MEDIA_PLAY_PAUSE = 0xb3;
        public const int VK_MEDIA_PREV_TRACK = 0xb1;
        public const int VK_MEDIA_STOP = 0xb2;
        public const int VK_MENU = 0x12;
        public const int VK_MODECHANGE = 0x1f;
        public const int VK_MULTIPLY = 0x6a;
        public const int VK_N = 0x4e;
        public const int VK_NEXT = 0x22;
        public const int VK_NONAME = 0xfc;
        public const int VK_NONCONVERT = 0x1d;
        public const int VK_NUMLOCK = 0x90;
        public const int VK_NUMPAD0 = 0x60;
        public const int VK_NUMPAD1 = 0x61;
        public const int VK_NUMPAD2 = 0x62;
        public const int VK_NUMPAD3 = 0x63;
        public const int VK_NUMPAD4 = 100;
        public const int VK_NUMPAD5 = 0x65;
        public const int VK_NUMPAD6 = 0x66;
        public const int VK_NUMPAD7 = 0x67;
        public const int VK_NUMPAD8 = 0x68;
        public const int VK_NUMPAD9 = 0x69;
        public const int VK_O = 0x4f;
        public const int VK_OEM_1 = 0xba;
        public const int VK_OEM_102 = 0xe2;
        public const int VK_OEM_2 = 0xbf;
        public const int VK_OEM_3 = 0xc0;
        public const int VK_OEM_4 = 0xdb;
        public const int VK_OEM_5 = 220;
        public const int VK_OEM_6 = 0xdd;
        public const int VK_OEM_7 = 0xde;
        public const int VK_OEM_8 = 0xdf;
        public const int VK_OEM_ATTN = 240;
        public const int VK_OEM_AUTO = 0xf3;
        public const int VK_OEM_AX = 0xe1;
        public const int VK_OEM_BACKTAB = 0xf5;
        public const int VK_OEM_CLEAR = 0xfe;
        public const int VK_OEM_COMMA = 0xbc;
        public const int VK_OEM_COPY = 0xf2;
        public const int VK_OEM_CUSEL = 0xef;
        public const int VK_OEM_ENLW = 0xf4;
        public const int VK_OEM_FINISH = 0xf1;
        public const int VK_OEM_JUMP = 0xea;
        public const int VK_OEM_MINUS = 0xbd;
        public const int VK_OEM_PA1 = 0xeb;
        public const int VK_OEM_PA2 = 0xec;
        public const int VK_OEM_PA3 = 0xed;
        public const int VK_OEM_PERIOD = 190;
        public const int VK_OEM_PLUS = 0xbb;
        public const int VK_OEM_RESET = 0xe9;
        public const int VK_OEM_WSCTRL = 0xee;
        public const int VK_P = 80;
        public const int VK_PA1 = 0xfd;
        public const int VK_PACKET = 0xe7;
        public const int VK_PAUSE = 0x13;
        public const int VK_PLAY = 250;
        public const int VK_POWER = 0x5e;
        public const int VK_PRINT = 0x2a;
        public const int VK_PRIOR = 0x21;
        public const int VK_PROCESSKEY = 0xe5;
        public const int VK_Q = 0x51;
        public const int VK_R = 0x52;
        public const int VK_RBUTTON = 2;
        public const int VK_RCONTROL = 0xa3;
        public const int VK_RETURN = 13;
        public const int VK_RIGHT = 0x27;
        public const int VK_RMENU = 0xa5;
        public const int VK_RSHIFT = 0xa1;
        public const int VK_RWIN = 0x5c;
        public const int VK_S = 0x53;
        public const int VK_SCROLL = 0x91;
        public const int VK_SELECT = 0x29;
        public const int VK_SEPARATOR = 0x6c;
        public const int VK_SHIFT = 0x10;
        public const int VK_SLEEP = 0x5f;
        public const int VK_SNAPSHOT = 0x2c;
        public const int VK_SPACE = 0x20;
        public const int VK_SUBTRACT = 0x6d;
        public const int VK_T = 0x54;
        public const int VK_TAB = 9;
        public const int VK_U = 0x55;
        public const int VK_UP = 0x26;
        public const int VK_V = 0x56;
        public const int VK_VOLUME_DOWN = 0xae;
        public const int VK_VOLUME_MUTE = 0xad;
        public const int VK_VOLUME_UP = 0xaf;
        public const int VK_W = 0x57;
        public const int VK_X = 0x58;
        public const int VK_XBUTTON1 = 5;
        public const int VK_XBUTTON2 = 6;
        public const int VK_Y = 0x59;
        public const int VK_Z = 90;
        public const int VK_ZOOM = 0xfb;
        public const int WA_ACTIVE = 1;
        public const int WA_CLICKACTIVE = 2;
        public const int WA_INACTIVE = 0;
        public const int WH_GETMESSAGE = 3;
        public const int WH_JOURNALPLAYBACK = 1;
        public const int WH_MOUSE = 7;
        public const int WHEEL_DELTA = 120;
        public const int WHITE_BRUSH = 0;
        public const int WINEVENT_OUTOFCONTEXT = 0;
        public const int WM_CHOOSEFONT_GETLOGFONT = 0x401;
        public const int WM_REFLECT = 0x2000;
        public const int WPF_RESTORETOMAXIMIZED = 2;
        public const int WPF_SETMINPOSITION = 1;
        public const uint WRITE_DAC = 0x40000;
        public const uint WRITE_OWNER = 0x80000;
        public const int WS_BORDER = 0x800000;
        public const int WS_CAPTION = 0xc00000;
        public const int WS_CHILD = 0x40000000;
        public const int WS_CLIPCHILDREN = 0x2000000;
        public const int WS_CLIPSIBLINGS = 0x4000000;
        public const int WS_DISABLED = 0x8000000;
        public const int WS_DLGFRAME = 0x400000;
        public const int WS_EX_APPWINDOW = 0x40000;
        public const int WS_EX_CLIENTEDGE = 0x200;
        public const int WS_EX_COMPOSITED = 0x2000000;
        public const int WS_EX_CONTEXTHELP = 0x400;
        public const int WS_EX_CONTROLPARENT = 0x10000;
        public const int WS_EX_DLGMODALFRAME = 1;
        public const int WS_EX_LAYERED = 0x80000;
        public const int WS_EX_LAYOUTRTL = 0x400000;
        public const int WS_EX_LEFT = 0;
        public const int WS_EX_LEFTSCROLLBAR = 0x4000;
        public const int WS_EX_MDICHILD = 0x40;
        public const int WS_EX_NOACTIVATE = 0x8000000;
        public const int WS_EX_NOINHERITLAYOUT = 0x100000;
        public const int WS_EX_RIGHT = 0x1000;
        public const int WS_EX_RTLREADING = 0x2000;
        public const int WS_EX_STATICEDGE = 0x20000;
        public const int WS_EX_TOOLWINDOW = 0x80;
        public const int WS_EX_TOPMOST = 8;
        public const int WS_EX_TRANSPARENT = 0x20;
        public const int WS_EX_WINDOWEDGE = 0x100;
        public const int WS_HSCROLL = 0x100000;
        public const int WS_MAXIMIZE = 0x1000000;
        public const int WS_MAXIMIZEBOX = 0x10000;
        public const int WS_MINIMIZE = 0x20000000;
        public const int WS_MINIMIZEBOX = 0x20000;
        public const int WS_OVERLAPPED = 0;
        public const int WS_OVERLAPPEDWINDOW = 0xcf0000;
        public const int WS_POPUP = -2147483648;
        public const int WS_SYSMENU = 0x80000;
        public const int WS_TABSTOP = 0x10000;
        public const int WS_THICKFRAME = 0x40000;
        public const int WS_VISIBLE = 0x10000000;
        public const int WS_VSCROLL = 0x200000;
        public const int WSF_VISIBLE = 1;
        public const uint WTNCA_NODRAWCAPTION = 1;
        public const uint WTNCA_NODRAWICON = 2;
        public const uint WTNCA_NOSYSMENU = 4;
        public const uint WTNCA_VALIDBITS = 7;
        public const int WTS_CONSOLE_CONNECT = 1;
        public const int WTS_CONSOLE_DISCONNECT = 2;
        public const int WTS_REMOTE_CONNECT = 3;
        public const int WTS_REMOTE_DISCONNECT = 4;
        public const int WTS_SESSION_LOCK = 7;
        public const int WTS_SESSION_UNLOCK = 8;
        public const int XBUTTON1 = 1;
        public const int XBUTTON2 = 2;
        public const int XFORMCOORDS_CONTAINERTOHIMETRIC = 8;
        public const int XFORMCOORDS_HIMETRICTOCONTAINER = 4;
        public const int XFORMCOORDS_POSITION = 1;
        public const int XFORMCOORDS_SIZE = 2;

        // Methods
        [SecurityCritical, DllImport("winspool.drv")]
        public static extern int ClosePrinter(IntPtr hPrinter);
        [SecurityCritical, DllImport("gdi32.dll")]
        public static extern int EndDoc(HDC hdc);
        [SecurityCritical, DllImport("gdi32.dll")]
        public static extern int EndPage(HDC hdc);
        [SecurityCritical, DllImport("gdi32.dll")]
        public static extern unsafe int ExtEscape(HDC hdc, int nEscape, int cbInput, PrinterEscape* lpvInData, int cbOutput, [Out] void* lpvOutData);
        public static bool Failed(int hr)
        {
            return (hr < 0);
        }

        public static int IntPtrToInt32(IntPtr intPtr)
        {
            return (int)intPtr.ToInt64();
        }

        public static int MakeHRFromErrorCode(int errorCode)
        {
            return (-2147024896 | errorCode);
        }

        [SecurityCritical, DllImport("winspool.drv")]
        public static extern unsafe int OpenPrinterA(string printerName, IntPtr* phPrinter, void* pDefaults);
        [SecurityCritical, DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr SetEnhMetaFileBits(uint cbBuffer, byte[] buffer);
        public static int SignedHIWORD(int n)
        {
            return (short)((n >> 0x10) & 0xffff);
        }

        public static int SignedHIWORD(IntPtr intPtr)
        {
            return SignedHIWORD(IntPtrToInt32(intPtr));
        }

        public static int SignedLOWORD(int n)
        {
            return (short)(n & 0xffff);
        }

        public static int SignedLOWORD(IntPtr intPtr)
        {
            return SignedLOWORD(IntPtrToInt32(intPtr));
        }

        [SecurityCritical, DllImport("gdi32.dll")]
        public static extern int StartDoc(HDC hdc, ref DocInfo docInfo);
        [SecurityCritical, DllImport("gdi32.dll")]
        public static extern int StartPage(HDC hdc);
        public static bool Succeeded(int hr)
        {
            return (hr >= 0);
        }

        // Nested Types
        [StructLayout(LayoutKind.Sequential)]
        public class ANIMATIONINFO
        {
            public int cbSize = SizeOf();
            public int iMinAnimate;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.ANIMATIONINFO));
            }
        }

        [SecurityCritical(SecurityCriticalScope.Everything)]
        public class AnsiCharBuffer : NativeMethods.CharBuffer
        {
            // Fields
            public byte[] buffer;
            public int offset;

            // Methods
            public AnsiCharBuffer(int size)
            {
                this.buffer = new byte[size];
            }

            public override IntPtr AllocCoTaskMem()
            {
                IntPtr destination = Marshal.AllocCoTaskMem(this.buffer.Length);
                Marshal.Copy(this.buffer, 0, destination, this.buffer.Length);
                return destination;
            }

            public override string GetString()
            {
                int offset = this.offset;
                while ((offset < this.buffer.Length) && (this.buffer[offset] != 0))
                {
                    offset++;
                }
                string str = Encoding.Default.GetString(this.buffer, this.offset, offset - this.offset);
                if (offset < this.buffer.Length)
                {
                    offset++;
                }
                this.offset = offset;
                return str;
            }

            public override void PutCoTaskMem(IntPtr ptr)
            {
                Marshal.Copy(ptr, this.buffer, 0, this.buffer.Length);
                this.offset = 0;
            }

            public override void PutString(string s)
            {
                byte[] bytes = Encoding.Default.GetBytes(s);
                int length = Math.Min(bytes.Length, this.buffer.Length - this.offset);
                Array.Copy(bytes, 0, this.buffer, this.offset, length);
                this.offset += length;
                if (this.offset < this.buffer.Length)
                {
                    this.buffer[this.offset++] = 0;
                }
            }

            // Properties
            public override int Length
            {
                get
                {
                    return this.buffer.Length;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class BITMAP
        {
            public int bmType;
            public int bmWidth;
            public int bmHeight;
            public int bmWidthBytes;
            public short bmPlanes;
            public short bmBitsPixel;
            public int bmBits;
        }

        public sealed class BitmapHandle : NativeMethods.WpfSafeHandle
        {
            // Methods
            [SecurityCritical, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            private BitmapHandle()
                : this(true)
            {
            }

            [SecurityCritical]
            private BitmapHandle(bool ownsHandle)
                : base(ownsHandle, NativeMethods.CommonHandles.GDI)
            {
            }

            [SecurityCritical]
            public static NativeMethods.BitmapHandle CreateFromHandle(IntPtr hbitmap, bool ownsHandle = true)
            {
                return new NativeMethods.BitmapHandle(ownsHandle) { handle = hbitmap };
            }

            [SecurityCritical]
            public HandleRef MakeHandleRef(object obj)
            {
                return new HandleRef(obj, base.handle);
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), SecurityCritical]
            protected override bool ReleaseHandle()
            {
                return UnsafeNativeMethods.DeleteObject(base.handle);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public struct BITMAPINFO
        {
            public int bmiHeader_biSize;
            public int bmiHeader_biWidth;
            public int bmiHeader_biHeight;
            public short bmiHeader_biPlanes;
            public short bmiHeader_biBitCount;
            public int bmiHeader_biCompression;
            public int bmiHeader_biSizeImage;
            public int bmiHeader_biXPelsPerMeter;
            public int bmiHeader_biYPelsPerMeter;
            public int bmiHeader_biClrUsed;
            public int bmiHeader_biClrImportant;
            public BITMAPINFO(int width, int height, short bpp)
            {
                this.bmiHeader_biSize = SizeOf();
                this.bmiHeader_biWidth = width;
                this.bmiHeader_biHeight = height;
                this.bmiHeader_biPlanes = 1;
                this.bmiHeader_biBitCount = bpp;
                this.bmiHeader_biCompression = 0;
                this.bmiHeader_biSizeImage = 0;
                this.bmiHeader_biXPelsPerMeter = 0;
                this.bmiHeader_biYPelsPerMeter = 0;
                this.bmiHeader_biClrUsed = 0;
                this.bmiHeader_biClrImportant = 0;
            }

            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.BITMAPINFO));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CANDIDATEFORM
        {
            public int dwIndex;
            public int dwStyle;
            public NativeMethods.POINT ptCurrentPos;
            public NativeMethods.RECT rcArea;
        }

        public abstract class CharBuffer
        {
            // Methods
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            protected CharBuffer()
            {
            }

            public abstract IntPtr AllocCoTaskMem();
            [SecurityCritical]
            public static NativeMethods.CharBuffer CreateBuffer(int size)
            {
                if (Marshal.SystemDefaultCharSize == 1)
                {
                    return new NativeMethods.AnsiCharBuffer(size);
                }
                return new NativeMethods.UnicodeCharBuffer(size);
            }

            public abstract string GetString();
            public abstract void PutCoTaskMem(IntPtr ptr);
            public abstract void PutString(string s);

            // Properties
            public abstract int Length { get; }
        }

        public enum ColorSpace : uint
        {
            SPACE_2_CHANNEL = 0x32434c52,
            SPACE_3_CHANNEL = 0x33434c52,
            SPACE_4_CHANNEL = 0x34434c52,
            SPACE_5_CHANNEL = 0x35434c52,
            SPACE_6_CHANNEL = 0x36434c52,
            SPACE_7_CHANNEL = 0x37434c52,
            SPACE_8_CHANNEL = 0x38434c52,
            SPACE_9_CHANNEL = 0x39434c52,
            SPACE_A_CHANNEL = 0x41434c52,
            SPACE_B_CHANNEL = 0x42434c52,
            SPACE_C_CHANNEL = 0x43434c52,
            SPACE_CMY = 0x434d5920,
            SPACE_CMYK = 0x434d594b,
            SPACE_D_CHANNEL = 0x44434c52,
            SPACE_E_CHANNEL = 0x45434c52,
            SPACE_F_CHANNEL = 0x46434c52,
            SPACE_GRAY = 0x47524159,
            SPACE_HLS = 0x484c5320,
            SPACE_HSV = 0x48535620,
            SPACE_Lab = 0x4c616220,
            SPACE_Luv = 0x4c757620,
            SPACE_RGB = 0x52474220,
            SPACE_sRGB = 0x73524742,
            SPACE_XYZ = 0x58595a20,
            SPACE_YCbCr = 0x59436272,
            SPACE_Yxy = 0x59787920
        }

        public enum COLORTYPE : uint
        {
            COLOR_3_CHANNEL = 6,
            COLOR_5_CHANNEL = 8,
            COLOR_6_CHANNEL = 9,
            COLOR_7_CHANNEL = 10,
            COLOR_8_CHANNEL = 11,
            COLOR_CMYK = 7,
            COLOR_GRAY = 1,
            COLOR_Lab = 5,
            COLOR_NAMED = 12,
            COLOR_RGB = 2,
            COLOR_UNDEFINED = 0xff,
            COLOR_XYZ = 3,
            COLOR_Yxy = 4
        }

        public static class CommonHandles
        {
            // Fields
            public static readonly int Accelerator = HandleCollector.RegisterType("Accelerator", 80, 50);
            public static readonly int Cursor = HandleCollector.RegisterType("Cursor", 20, 500);
            public static readonly int EMF = HandleCollector.RegisterType("EnhancedMetaFile", 20, 500);
            public static readonly int Find = HandleCollector.RegisterType("Find", 0, 0x3e8);
            public static readonly int GDI = HandleCollector.RegisterType("GDI", 50, 500);
            public static readonly int HDC = HandleCollector.RegisterType("HDC", 100, 2);
            public static readonly int Icon = HandleCollector.RegisterType("Icon", 20, 500);
            public static readonly int Kernel = HandleCollector.RegisterType("Kernel", 0, 0x3e8);
            public static readonly int Menu = HandleCollector.RegisterType("Menu", 30, 0x3e8);
            public static readonly int Window = HandleCollector.RegisterType("Window", 5, 0x3e8);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COMPOSITIONFORM
        {
            public int dwStyle;
            public NativeMethods.POINT ptCurrentPos;
            public NativeMethods.RECT rcArea;
        }

        [Serializable, StructLayout(LayoutKind.Sequential)]
        public class COMRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public COMRECT(int x, int y, int right, int bottom)
            {
                this.left = x;
                this.top = y;
                this.right = right;
                this.bottom = bottom;
            }

            public COMRECT(NativeMethods.RECT rect)
            {
                this.left = rect.left;
                this.top = rect.top;
                this.bottom = rect.bottom;
                this.right = rect.right;
            }

            public void CopyTo(NativeMethods.COMRECT destRect)
            {
                destRect.left = this.left;
                destRect.right = this.right;
                destRect.top = this.top;
                destRect.bottom = this.bottom;
            }

            public bool IsEmpty
            {
                get
                {
                    return ((this.left == this.right) && (this.top == this.bottom));
                }
            }
            public override string ToString()
            {
                return string.Concat(new object[] { "Left = ", this.left, " Top ", this.top, " Right = ", this.right, " Bottom = ", this.bottom });
            }
        }

        public sealed class CursorHandle : NativeMethods.WpfSafeHandle
        {
            // Methods
            [SecurityCritical]
            private CursorHandle()
                : base(true, NativeMethods.CommonHandles.Cursor)
            {
            }

            [SecurityCritical, SecurityTreatAsSafe]
            public static NativeMethods.CursorHandle GetInvalidCursor()
            {
                return new NativeMethods.CursorHandle();
            }

            [SecurityCritical, ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
            protected override bool ReleaseHandle()
            {
                return UnsafeNativeMethods.DestroyCursor(base.handle);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class DISPPARAMS
        {
            public IntPtr rgvarg;
            public IntPtr rgdispidNamedArgs;
            [MarshalAs(UnmanagedType.U4)]
            public uint cArgs;
            [MarshalAs(UnmanagedType.U4)]
            public uint cNamedArgs;
        }

        public enum DOCHOSTUIDBLCLICK
        {
            DEFAULT,
            SHOWPROPERTIES,
            SHOWCODE
        }

        public enum DOCHOSTUIFLAG
        {
            ACTIVATE_CLIENTHIT_ONLY = 0x200,
            DIALOG = 1,
            DISABLE_COOKIE = 0x400,
            DISABLE_EDIT_NS_FIXUP = 0x400000,
            DISABLE_HELP_MENU = 2,
            DISABLE_OFFSCREEN = 0x40,
            DISABLE_SCRIPT_INACTIVE = 0x10,
            DISABLE_UNTRUSTEDPROTOCOL = 0x1000000,
            DIV_BLOCKDEFAULT = 0x100,
            ENABLE_FORMS_AUTOCOMPLETE = 0x4000,
            ENABLE_INPLACE_NAVIGATION = 0x10000,
            ENABLE_REDIRECT_NOTIFICATION = 0x4000000,
            FLAT_SCROLLBAR = 0x80,
            HOST_NAVIGATES = 0x2000000,
            IME_ENABLE_RECONVERSION = 0x20000,
            LOCAL_MACHINE_ACCESS_CHECK = 0x800000,
            NO3DBORDER = 4,
            NO3DOUTERBORDER = 0x200000,
            NOPICS = 0x100000,
            NOTHEME = 0x80000,
            OPENNEWWIN = 0x20,
            SCROLL_NO = 8,
            THEME = 0x40000
        }

        [StructLayout(LayoutKind.Sequential), ComVisible(true)]
        public class DOCHOSTUIINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cbSize = SizeOf();
            [MarshalAs(UnmanagedType.I4)]
            public int dwFlags;
            [MarshalAs(UnmanagedType.I4)]
            public int dwDoubleClick;
            [MarshalAs(UnmanagedType.I4)]
            public int dwReserved1;
            [MarshalAs(UnmanagedType.I4)]
            public int dwReserved2;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.DOCHOSTUIINFO));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DocInfo
        {
            public int cbSize;
            public string lpszName;
            public string lpszOutput;
            public string lpszDatatype;
            public int fwType;
        }

        public delegate bool EnumThreadWindowsCallback(IntPtr hWnd, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public class EXCEPINFO
        {
            [MarshalAs(UnmanagedType.U2)]
            public ushort wCode;
            [MarshalAs(UnmanagedType.U2)]
            public ushort wReserved;
            [MarshalAs(UnmanagedType.BStr)]
            public string bstrSource;
            [MarshalAs(UnmanagedType.BStr)]
            public string bstrDescription;
            [MarshalAs(UnmanagedType.BStr)]
            public string bstrHelpFile;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwHelpContext;
            public IntPtr pvReserved;
            public IntPtr pfnDeferredFillIn;
            [MarshalAs(UnmanagedType.I4)]
            public int scode;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GUID
        {
            public Guid guid;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public GUID(Guid guid)
            {
                this.guid = guid;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HDC
        {
            public IntPtr h;
            public static NativeMethods.HDC Cast(IntPtr h)
            {
                return new NativeMethods.HDC { h = h };
            }

            public HandleRef MakeHandleRef(object wrapper)
            {
                return new HandleRef(wrapper, this.h);
            }

            public static NativeMethods.HDC NULL
            {
                get
                {
                    return new NativeMethods.HDC { h = IntPtr.Zero };
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct HIGHCONTRAST_I
        {
            public int cbSize;
            public int dwFlags;
            public IntPtr lpszDefaultScheme;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HWND
        {
            public IntPtr h;
            public static NativeMethods.HWND Cast(IntPtr h)
            {
                return new NativeMethods.HWND { h = h };
            }

            public HandleRef MakeHandleRef(object wrapper)
            {
                return new HandleRef(wrapper, this.h);
            }

            public static implicit operator IntPtr(NativeMethods.HWND h)
            {
                return h.h;
            }

            public static bool operator ==(NativeMethods.HWND hl, NativeMethods.HWND hr)
            {
                return (hl.h == hr.h);
            }

            public static bool operator !=(NativeMethods.HWND hl, NativeMethods.HWND hr)
            {
                return (hl.h != hr.h);
            }

            public override bool Equals(object oCompare)
            {
                NativeMethods.HWND hwnd = Cast((IntPtr)((NativeMethods.HWND)oCompare));
                return (this.h == hwnd.h);
            }

            public override int GetHashCode()
            {
                return (int)this.h;
            }
        }

        public sealed class IconHandle : NativeMethods.WpfSafeHandle
        {
            // Methods
            [SecurityCritical]
            private IconHandle()
                : base(true, NativeMethods.CommonHandles.Icon)
            {
            }

            [SecurityCritical]
            public IntPtr CriticalGetHandle()
            {
                return base.handle;
            }

            [SecurityTreatAsSafe, SecurityCritical]
            public static NativeMethods.IconHandle GetInvalidIcon()
            {
                return new NativeMethods.IconHandle();
            }

            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail), SecurityCritical]
            protected override bool ReleaseHandle()
            {
                return UnsafeNativeMethods.DestroyIcon(base.handle);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ICONINFO
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public NativeMethods.BitmapHandle hbmMask;
            public NativeMethods.BitmapHandle hbmColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ICONMETRICS
        {
            public int cbSize = SizeOf();
            public int iHorzSpacing;
            public int iVertSpacing;
            public int iTitleWrap;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfFont;
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.ICONMETRICS));
            }
        }

        [ComImport, Guid("79eac9ee-baf9-11ce-8c82-00aa004ba90b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface IInternetSecurityMgrSite
        {
            void GetWindow(ref IntPtr phwnd);
            void EnableModeless(bool fEnable);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct InternetCacheConfigInfo
        {
            public uint dwStructSize;
            public uint dwContainer;
            public uint dwQuota;
            public uint dwReserved4;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fPerUser;
            public uint dwSyncMode;
            public uint dwNumCachePaths;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string CachePath;
            public uint dwCacheSize;
            public uint dwNormalUsage;
            public uint dwExemptUsage;
        }

        [ComImport, Guid("B722BCCB-4E68-101B-A2BC-00AA00404770"), ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), SecurityCritical, SuppressUnmanagedCodeSecurity]
        public interface IOleCommandTarget
        {
            [return: MarshalAs(UnmanagedType.I4)]
            [PreserveSig, SecurityCritical]
            int QueryStatus(NativeMethods.GUID pguidCmdGroup, int cCmds, [In, Out] NativeMethods.OLECMD prgCmds, [In, Out] IntPtr pCmdText);
            [return: MarshalAs(UnmanagedType.I4)]
            [PreserveSig, SecurityCritical]
            int Exec(NativeMethods.GUID pguidCmdGroup, int nCmdID, int nCmdexecopt, [In, MarshalAs(UnmanagedType.LPArray)] object[] pvaIn, int pvaOut);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string lfFaceName;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public LOGFONT()
            {
            }

            public LOGFONT(NativeMethods.LOGFONT lf)
            {
                if (lf == null)
                {
                    throw new ArgumentNullException("lf");
                }
                this.lfHeight = lf.lfHeight;
                this.lfWidth = lf.lfWidth;
                this.lfEscapement = lf.lfEscapement;
                this.lfOrientation = lf.lfOrientation;
                this.lfWeight = lf.lfWeight;
                this.lfItalic = lf.lfItalic;
                this.lfUnderline = lf.lfUnderline;
                this.lfStrikeOut = lf.lfStrikeOut;
                this.lfCharSet = lf.lfCharSet;
                this.lfOutPrecision = lf.lfOutPrecision;
                this.lfClipPrecision = lf.lfClipPrecision;
                this.lfQuality = lf.lfQuality;
                this.lfPitchAndFamily = lf.lfPitchAndFamily;
                this.lfFaceName = lf.lfFaceName;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class MENUITEMINFO_T
        {
            public int cbSize = SizeOf();
            public int fMask;
            public int fType;
            public int fState;
            public int wID;
            public IntPtr hSubMenu = IntPtr.Zero;
            public IntPtr hbmpChecked = IntPtr.Zero;
            public IntPtr hbmpUnchecked = IntPtr.Zero;
            public int dwItemData;
            public string dwTypeData;
            public int cch;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.MENUITEMINFO_T));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MINMAXINFO
        {
            public NativeMethods.POINT ptReserved = new NativeMethods.POINT();
            public NativeMethods.POINT ptMaxSize = new NativeMethods.POINT();
            public NativeMethods.POINT ptMaxPosition = new NativeMethods.POINT();
            public NativeMethods.POINT ptMinTrackSize = new NativeMethods.POINT();
            public NativeMethods.POINT ptMaxTrackSize = new NativeMethods.POINT();
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 4)]
        public class MONITORINFOEX
        {
            public int cbSize = SizeOf();
            public NativeMethods.RECT rcMonitor = new NativeMethods.RECT();
            public NativeMethods.RECT rcWork = new NativeMethods.RECT();
            public int dwFlags;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x20)]
            public char[] szDevice = new char[0x20];
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.MONITORINFOEX));
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct MOUSEMOVEPOINT
        {
            public int x;
            public int y;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class NONCLIENTMETRICS
        {
            public int cbSize = SizeOf();
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfCaptionFont;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfSmCaptionFont;
            public int iMenuWidth;
            public int iMenuHeight;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfMenuFont;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfStatusFont;
            [MarshalAs(UnmanagedType.Struct)]
            public NativeMethods.LOGFONT lfMessageFont;
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.NONCLIENTMETRICS));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OFNOTIFY
        {
            public IntPtr hdr_hwndFrom;
            public IntPtr hdr_idFrom;
            public int hdr_code;
            public IntPtr lpOFN;
            public IntPtr pszFile;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OLECMD
        {
            [MarshalAs(UnmanagedType.U4)]
            public int cmdID;
            [MarshalAs(UnmanagedType.U4)]
            public int cmdf;
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class OLEINPLACEFRAMEINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint cb;
            public bool fMDIApp;
            public IntPtr hwndFrame;
            public IntPtr hAccel;
            [MarshalAs(UnmanagedType.U4)]
            public uint cAccelEntries;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class OPENFILENAME_I
        {
            public int lStructSize = SizeOf();
            public IntPtr hwndOwner;
            public IntPtr hInstance;
            public string lpstrFilter;
            public IntPtr lpstrCustomFilter;
            public int nMaxCustFilter;
            public int nFilterIndex;
            public IntPtr lpstrFile;
            public int nMaxFile = 260;
            public IntPtr lpstrFileTitle;
            public int nMaxFileTitle = 260;
            public string lpstrInitialDir;
            public string lpstrTitle;
            public int Flags;
            public short nFileOffset;
            public short nFileExtension;
            public string lpstrDefExt;
            public IntPtr lCustData;
            public NativeMethods.WndProc lpfnHook;
            public string lpTemplateName;
            public IntPtr pvReserved;
            public int dwReserved;
            public int FlagsEx;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.OPENFILENAME_I));
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public sealed class OSVERSIONINFOEX
        {
            public int osVersionInfoSize = SizeOf();
            public int majorVersion;
            public int minorVersion;
            public int buildNumber;
            public int platformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
            public string csdVersion;
            public short servicePackMajor;
            public short servicePackMinor;
            public short suiteMask;
            public byte productType;
            public byte reserved;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.OSVERSIONINFOEX));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT
        {
            public IntPtr hdc;
            public bool fErase;
            public int rcPaint_left;
            public int rcPaint_top;
            public int rcPaint_right;
            public int rcPaint_bottom;
            public bool fRestore;
            public bool fIncUpdate;
            public int reserved1;
            public int reserved2;
            public int reserved3;
            public int reserved4;
            public int reserved5;
            public int reserved6;
            public int reserved7;
            public int reserved8;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class POINT
        {
            public int x;
            public int y;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public POINT()
            {
            }

            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class POINTF
        {
            [MarshalAs(UnmanagedType.R4)]
            public float x;
            [MarshalAs(UnmanagedType.R4)]
            public float y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINTSTRUCT
        {
            public int x;
            public int y;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public POINTSTRUCT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct POWERBROADCAST_SETTING
        {
            public Guid PowerSetting;
            public int DataLength;
            public byte Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PrinterEscape
        {
            public int cbInput;
            public uint cbOutput;
            public uint opcode;
            public int cbSize;
            [SecurityCritical]
            public unsafe void* buffer;
        }

        public enum ProfileType : uint
        {
            PROFILE_FILENAME = 1,
            PROFILE_MEMBUFFER = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RAWINPUTDEVICELIST
        {
            public IntPtr hDevice;
            public uint dwType;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECONVERTSTRING
        {
            public int dwSize;
            public int dwVersion;
            public int dwStrLen;
            public int dwStrOffset;
            public int dwCompStrLen;
            public int dwCompStrOffset;
            public int dwTargetStrLen;
            public int dwTargetStrOffset;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }

            public int Width
            {
                get
                {
                    return (this.right - this.left);
                }
            }
            public int Height
            {
                get
                {
                    return (this.bottom - this.top);
                }
            }
            public void Offset(int dx, int dy)
            {
                this.left += dx;
                this.top += dy;
                this.right += dx;
                this.bottom += dy;
            }

            public bool IsEmpty
            {
                get
                {
                    if (this.left < this.right)
                    {
                        return (this.top >= this.bottom);
                    }
                    return true;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class RefRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public RefRECT()
            {
            }

            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public RefRECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }

            public int Width
            {
                get
                {
                    return (this.right - this.left);
                }
            }
            public int Height
            {
                get
                {
                    return (this.bottom - this.top);
                }
            }
            public void Offset(int dx, int dy)
            {
                this.left += dx;
                this.top += dy;
                this.right += dx;
                this.bottom += dy;
            }

            public bool IsEmpty
            {
                get
                {
                    if (this.left < this.right)
                    {
                        return (this.top >= this.bottom);
                    }
                    return true;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct REGISTERWORD
        {
            public string lpReading;
            public string lpWord;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct RID_DEVICE_INFO
        {
            // Fields
            [FieldOffset(0)]
            public uint cbSize;
            [FieldOffset(4)]
            public uint dwType;
            [FieldOffset(8)]
            public NativeMethods.RID_DEVICE_INFO_HID hid;
            [FieldOffset(8)]
            public NativeMethods.RID_DEVICE_INFO_KEYBOARD keyboard;
            [FieldOffset(8)]
            public NativeMethods.RID_DEVICE_INFO_MOUSE mouse;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RID_DEVICE_INFO_HID
        {
            public uint dwVendorId;
            public uint dwProductId;
            public uint dwVersionNumber;
            public ushort usUsagePage;
            public ushort usUsage;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RID_DEVICE_INFO_KEYBOARD
        {
            public uint dwType;
            public uint dwSubType;
            public uint dwKeyboardMode;
            public uint dwNumberOfFunctionKeys;
            public uint dwNumberOfIndicators;
            public uint dwNumberOfKeysTotal;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RID_DEVICE_INFO_MOUSE
        {
            public uint dwId;
            public uint dwNumberOfButtons;
            public uint dwSampleRate;
        }

        [SecurityCritical, SuppressUnmanagedCodeSecurity, HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
        public sealed class SafeLocalMemHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            // Methods
            [SecurityCritical]
            public SafeLocalMemHandle()
                : base(true)
            {
            }

            [SecurityCritical]
            public SafeLocalMemHandle(IntPtr existingHandle, bool ownsHandle)
                : base(ownsHandle)
            {
                base.SetHandle(existingHandle);
            }

            [SecurityCritical, SuppressUnmanagedCodeSecurity, ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), DllImport("kernel32.dll")]
            private static extern IntPtr LocalFree(IntPtr hMem);
            [SecurityCritical]
            protected override bool ReleaseHandle()
            {
                return (LocalFree(base.handle) == IntPtr.Zero);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SECURITY_ATTRIBUTES
        {
            public int nLength = SizeOf();
            [SecurityCritical]
            public NativeMethods.SafeLocalMemHandle lpSecurityDescriptor = new NativeMethods.SafeLocalMemHandle();
            public bool bInheritHandle;
            [SecuritySafeCritical]
            public SECURITY_ATTRIBUTES()
            {
                this.lpSecurityDescriptor = new NativeMethods.SafeLocalMemHandle();
            }

            [SecurityCritical]
            public void Release()
            {
                if (this.lpSecurityDescriptor != null)
                {
                    this.lpSecurityDescriptor.Dispose();
                    this.lpSecurityDescriptor = new NativeMethods.SafeLocalMemHandle();
                }
            }

            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.SECURITY_ATTRIBUTES));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SIZE
        {
            public int cx;
            public int cy;
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public SIZE()
            {
            }

            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public SIZE(int cx, int cy)
            {
                this.cx = cx;
                this.cy = cy;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class STATDATA
        {
            [MarshalAs(UnmanagedType.U4)]
            public int advf;
            [MarshalAs(UnmanagedType.U4)]
            public int dwConnection;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class STATSTG
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pwcsName;
            public int type;
            [MarshalAs(UnmanagedType.I8)]
            public long cbSize;
            [MarshalAs(UnmanagedType.I8)]
            public long mtime;
            [MarshalAs(UnmanagedType.I8)]
            public long ctime;
            [MarshalAs(UnmanagedType.I8)]
            public long atime;
            [MarshalAs(UnmanagedType.I4)]
            public int grfMode;
            [MarshalAs(UnmanagedType.I4)]
            public int grfLocksSupported;
            public int clsid_data1;
            [MarshalAs(UnmanagedType.I2)]
            public short clsid_data2;
            [MarshalAs(UnmanagedType.I2)]
            public short clsid_data3;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b0;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b1;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b2;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b3;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b4;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b5;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b6;
            [MarshalAs(UnmanagedType.U1)]
            public byte clsid_b7;
            [MarshalAs(UnmanagedType.I4)]
            public int grfStateBits;
            [MarshalAs(UnmanagedType.I4)]
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STYLESTRUCT
        {
            public int styleOld;
            public int styleNew;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public int BatteryLifeTime;
            public int BatteryFullLifeTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class tagCONTROLINFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint cb = ((uint)SizeOf());
            public IntPtr hAccel;
            [MarshalAs(UnmanagedType.U2)]
            public ushort cAccel;
            [MarshalAs(UnmanagedType.U4)]
            public uint dwFlags;
            [SecuritySafeCritical]
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.tagCONTROLINFO));
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class tagLOGPALETTE
        {
            [MarshalAs(UnmanagedType.U2)]
            public ushort palVersion;
            [MarshalAs(UnmanagedType.U2)]
            public ushort palNumEntries;
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class tagOleMenuGroupWidths
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] widths = new int[6];
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class tagOLEVERB
        {
            public int lVerb;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszVerbName;
            [MarshalAs(UnmanagedType.U4)]
            public uint fuFlags;
            [MarshalAs(UnmanagedType.U4)]
            public uint grfAttribs;
        }

        public enum tagVT
        {
            VT_ARRAY = 0x2000,
            VT_BLOB = 0x41,
            VT_BLOB_OBJECT = 70,
            VT_BOOL = 11,
            VT_BSTR = 8,
            VT_BSTR_BLOB = 0xfff,
            VT_BYREF = 0x4000,
            VT_CARRAY = 0x1c,
            VT_CF = 0x47,
            VT_CLSID = 0x48,
            VT_CY = 6,
            VT_DATE = 7,
            VT_DECIMAL = 14,
            VT_DISPATCH = 9,
            VT_EMPTY = 0,
            VT_ERROR = 10,
            VT_FILETIME = 0x40,
            VT_HRESULT = 0x19,
            VT_I1 = 0x10,
            VT_I2 = 2,
            VT_I4 = 3,
            VT_I8 = 20,
            VT_ILLEGAL = 0xffff,
            VT_ILLEGALMASKED = 0xfff,
            VT_INT = 0x16,
            VT_LPSTR = 30,
            VT_LPWSTR = 0x1f,
            VT_NULL = 1,
            VT_PTR = 0x1a,
            VT_R4 = 4,
            VT_R8 = 5,
            VT_RECORD = 0x24,
            VT_RESERVED = 0x8000,
            VT_SAFEARRAY = 0x1b,
            VT_STORAGE = 0x43,
            VT_STORED_OBJECT = 0x45,
            VT_STREAM = 0x42,
            VT_STREAMED_OBJECT = 0x44,
            VT_TYPEMASK = 0xfff,
            VT_UI1 = 0x11,
            VT_UI2 = 0x12,
            VT_UI4 = 0x13,
            VT_UI8 = 0x15,
            VT_UINT = 0x17,
            VT_UNKNOWN = 13,
            VT_USERDEFINED = 0x1d,
            VT_VARIANT = 12,
            VT_VECTOR = 0x1000,
            VT_VOID = 0x18
        }

        public delegate void TimerProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public class TRACKMOUSEEVENT
        {
            public int cbSize = SizeOf();
            public int dwFlags;
            public IntPtr hwndTrack = IntPtr.Zero;
            public int dwHoverTime = 100;
            private static int SizeOf()
            {
                return Marshal.SizeOf(typeof(NativeMethods.TRACKMOUSEEVENT));
            }
        }

        [SecurityCritical(SecurityCriticalScope.Everything)]
        public class UnicodeCharBuffer : NativeMethods.CharBuffer
        {
            // Fields
            public char[] buffer;
            public int offset;

            // Methods
            public UnicodeCharBuffer(int size)
            {
                this.buffer = new char[size];
            }

            public override IntPtr AllocCoTaskMem()
            {
                IntPtr destination = Marshal.AllocCoTaskMem(this.buffer.Length * 2);
                Marshal.Copy(this.buffer, 0, destination, this.buffer.Length);
                return destination;
            }

            public override string GetString()
            {
                int offset = this.offset;
                while ((offset < this.buffer.Length) && (this.buffer[offset] != '\0'))
                {
                    offset++;
                }
                string str = new string(this.buffer, this.offset, offset - this.offset);
                if (offset < this.buffer.Length)
                {
                    offset++;
                }
                this.offset = offset;
                return str;
            }

            public override void PutCoTaskMem(IntPtr ptr)
            {
                Marshal.Copy(ptr, this.buffer, 0, this.buffer.Length);
                this.offset = 0;
            }

            public override void PutString(string s)
            {
                int count = Math.Min(s.Length, this.buffer.Length - this.offset);
                s.CopyTo(0, this.buffer, this.offset, count);
                this.offset += count;
                if (this.offset < this.buffer.Length)
                {
                    this.buffer[this.offset++] = '\0';
                }
            }

            // Properties
            public override int Length
            {
                get
                {
                    return this.buffer.Length;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public sealed class VARIANT
        {
            [MarshalAs(UnmanagedType.I2)]
            public short vt;
            [MarshalAs(UnmanagedType.I2)]
            public short reserved1;
            [MarshalAs(UnmanagedType.I2)]
            public short reserved2;
            [MarshalAs(UnmanagedType.I2)]
            public short reserved3;
            public SecurityCriticalDataForSet<IntPtr> data1;
            public SecurityCriticalDataForSet<IntPtr> data2;
            public bool Byref
            {
                get
                {
                    return (0 != (this.vt & 0x4000));
                }
            }
            [SecurityCritical, SecurityTreatAsSafe]
            public void Clear()
            {
                if (((this.vt == 13) || (this.vt == 9)) && (this.data1.Value != IntPtr.Zero))
                {
                    Marshal.Release(this.data1.Value);
                }
                if ((this.vt == 8) && (this.data1.Value != IntPtr.Zero))
                {
                    SysFreeString(this.data1.Value);
                }
                this.data1.Value = this.data2.Value = IntPtr.Zero;
                this.vt = 0;
            }

            ~VARIANT()
            {
                this.Clear();
            }

            public void SuppressFinalize()
            {
                GC.SuppressFinalize(this);
            }

            [SecurityCritical]
            public void SetLong(long lVal)
            {
                this.data1.Value = (IntPtr)(((ulong)lVal) & 0xffffffffL);
                this.data2.Value = (IntPtr)(((ulong)(lVal >> 0x20)) & 0xffffffffL);
            }

            [SecurityCritical]
            public IntPtr ToCoTaskMemPtr()
            {
                IntPtr ptr = Marshal.AllocCoTaskMem(0x10);
                Marshal.WriteInt16(ptr, this.vt);
                Marshal.WriteInt16(ptr, 2, this.reserved1);
                Marshal.WriteInt16(ptr, 4, this.reserved2);
                Marshal.WriteInt16(ptr, 6, this.reserved3);
                Marshal.WriteInt32(ptr, 8, (int)this.data1.Value);
                Marshal.WriteInt32(ptr, 12, (int)this.data2.Value);
                return ptr;
            }

            [SecurityCritical]
            public object ToObject()
            {
                long num;
                IntPtr refInt = this.data1.Value;
                int num4 = this.vt & 0xfff;
                switch (num4)
                {
                    case 0:
                        return null;

                    case 1:
                        return Convert.DBNull;

                    case 2:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadInt16(refInt);
                        }
                        return (short)(0xffff & ((short)((int)refInt)));

                    case 3:
                    case 0x16:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadInt32(refInt);
                        }
                        return (int)refInt;

                    case 0x10:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadByte(refInt);
                        }
                        return (sbyte)(0xff & ((sbyte)((int)refInt)));

                    case 0x11:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadByte(refInt);
                        }
                        return (byte)(0xff & ((byte)((int)refInt)));

                    case 0x12:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadInt16(refInt);
                        }
                        return (ushort)(0xffff & ((ushort)((int)refInt)));

                    case 0x13:
                    case 0x17:
                        if (this.Byref)
                        {
                            refInt = (IntPtr)Marshal.ReadInt32(refInt);
                        }
                        return (uint)((int)refInt);

                    case 20:
                    case 0x15:
                        if (!this.Byref)
                        {
                            num = (long)((ulong)((((int)this.data1.Value) & -1) | ((int)this.data2.Value)));
                            break;
                        }
                        num = Marshal.ReadInt64(refInt);
                        break;

                    default:
                        if (this.Byref)
                        {
                            refInt = GetRefInt(refInt);
                        }
                        switch (num4)
                        {
                            case 0xfff:
                            case 0x1000:
                            case 0x2000:
                            case 0x4000:
                            case 10:
                            case 15:
                            case 0x10:
                            case 0x11:
                            case 0x12:
                            case 0x13:
                            case 20:
                            case 0x15:
                            case 0x16:
                            case 0x17:
                            case 0x18:
                            case 0x1a:
                            case 0x1b:
                            case 0x1c:
                            case 0x1d:
                            case 0x20:
                            case 0x21:
                            case 0x22:
                            case 0x23:
                            case 0x24:
                            case 0x41:
                            case 0x42:
                            case 0x43:
                            case 0x44:
                            case 0x45:
                            case 70:
                            case 0x47:
                                goto Label_03A8;

                            case 4:
                            case 5:
                                throw new FormatException();

                            case 6:
                                return new decimal((long)((ulong)((((int)this.data1.Value) & -1) | ((int)this.data2.Value))));

                            case 7:
                                throw new FormatException();

                            case 8:
                            case 0x1f:
                                return Marshal.PtrToStringUni(refInt);

                            case 9:
                            case 13:
                                return Marshal.GetObjectForIUnknown(refInt);

                            case 11:
                                return (refInt != IntPtr.Zero);

                            case 12:
                                {
                                    NativeMethods.VARIANT variant = (NativeMethods.VARIANT)UnsafeNativeMethods.PtrToStructure(refInt, typeof(NativeMethods.VARIANT));
                                    return variant.ToObject();
                                }
                            case 14:
                                return new decimal((long)((ulong)((((int)this.data1.Value) & -1) | ((int)this.data2.Value))));

                            case 0x19:
                                return refInt;

                            case 30:
                                return Marshal.PtrToStringAnsi(refInt);

                            case 0x40:
                                num = (long)((ulong)((((int)this.data1.Value) & -1) | ((int)this.data2.Value)));
                                return new DateTime(num);

                            case 0x48:
                                return (Guid)UnsafeNativeMethods.PtrToStructure(refInt, typeof(Guid));
                        }
                        goto Label_03A8;
                }
                if (this.vt == 20)
                {
                    return num;
                }
                return (ulong)num;
            Label_03A8:
                return null;
            }

            [DllImport("oleaut32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SysAllocString([In, MarshalAs(UnmanagedType.LPWStr)] string s);
            [DllImport("oleaut32.dll", CharSet = CharSet.Auto)]
            private static extern void SysFreeString(IntPtr pbstr);
            [SecurityCritical]
            private static IntPtr GetRefInt(IntPtr value)
            {
                return Marshal.ReadIntPtr(value);
            }
        }

        public enum WebBrowserReadyState
        {
            UnInitialized,
            Loading,
            Loaded,
            Interactive,
            Complete
        }

        public enum Win32SystemColors
        {
            ActiveBorder = 10,
            ActiveCaption = 2,
            ActiveCaptionText = 9,
            AppWorkspace = 12,
            Control = 15,
            ControlDark = 0x10,
            ControlDarkDark = 0x15,
            ControlLight = 0x16,
            ControlLightLight = 20,
            ControlText = 0x12,
            Desktop = 1,
            GradientActiveCaption = 0x1b,
            GradientInactiveCaption = 0x1c,
            GrayText = 0x11,
            Highlight = 13,
            HighlightText = 14,
            HotTrack = 0x1a,
            InactiveBorder = 11,
            InactiveCaption = 3,
            InactiveCaptionText = 0x13,
            Info = 0x18,
            InfoText = 0x17,
            Menu = 4,
            MenuBar = 30,
            MenuHighlight = 0x1d,
            MenuText = 7,
            ScrollBar = 0,
            Window = 5,
            WindowFrame = 6,
            WindowText = 8
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public int ptMinPosition_x;
            public int ptMinPosition_y;
            public int ptMaxPosition_x;
            public int ptMaxPosition_y;
            public int rcNormalPosition_left;
            public int rcNormalPosition_top;
            public int rcNormalPosition_right;
            public int rcNormalPosition_bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        public enum WINDOWTHEMEATTRIBUTETYPE
        {
            WTA_NONCLIENT = 1
        }

        public delegate void WinEventProcDef(int winEventHook, int eventId, IntPtr hwnd, int idObject, int idChild, int eventThread, int eventTime);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class WNDCLASSEX_D
        {
            public int cbSize;
            public int style;
            public NativeMethods.WndProc lpfnWndProc;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance = IntPtr.Zero;
            public IntPtr hIcon = IntPtr.Zero;
            public IntPtr hCursor = IntPtr.Zero;
            public IntPtr hbrBackground = IntPtr.Zero;
            public string lpszMenuName;
            public string lpszClassName;
            public IntPtr hIconSm = IntPtr.Zero;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class WNDCLASSEX_I
        {
            public int cbSize;
            public int style;
            public IntPtr lpfnWndProc = IntPtr.Zero;
            public int cbClsExtra;
            public int cbWndExtra;
            public IntPtr hInstance = IntPtr.Zero;
            public IntPtr hIcon = IntPtr.Zero;
            public IntPtr hCursor = IntPtr.Zero;
            public IntPtr hbrBackground = IntPtr.Zero;
            public IntPtr lpszMenuName = IntPtr.Zero;
            public IntPtr lpszClassName = IntPtr.Zero;
            public IntPtr hIconSm = IntPtr.Zero;
        }

        public delegate IntPtr WndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class XFORM
        {
            public float eM11;
            public float eM12;
            public float eM21;
            public float eM22;
            public float eDx;
            public float eDy;
            public XFORM()
            {
                this.eM11 = this.eM22 = 1f;
            }

            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public XFORM(float em11, float em12, float em21, float em22, float edx, float edy)
            {
                this.eM11 = em11;
                this.eM12 = em12;
                this.eM21 = em21;
                this.eM22 = em22;
                this.eDx = edx;
                this.eDy = edy;
            }

            public XFORM(float[] elements)
            {
                this.eM11 = elements[0];
                this.eM12 = elements[1];
                this.eM21 = elements[2];
                this.eM22 = elements[3];
                this.eDx = elements[4];
                this.eDy = elements[5];
            }

            public override string ToString()
            {
                return string.Format(CultureInfo.CurrentCulture, "[{0}, {1}, {2}, {3}, {4}, {5}]", new object[] { this.eM11, this.eM12, this.eM21, this.eM22, this.eDx, this.eDy });
            }

            public override bool Equals(object obj)
            {
                NativeMethods.XFORM xform = obj as NativeMethods.XFORM;
                if (xform == null)
                {
                    return false;
                }
                return (((((this.eM11 == xform.eM11) && (this.eM12 == xform.eM12)) && ((this.eM21 == xform.eM21) && (this.eM22 == xform.eM22))) && (this.eDx == xform.eDx)) && (this.eDy == xform.eDy));
            }

            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
        }
    }
}
