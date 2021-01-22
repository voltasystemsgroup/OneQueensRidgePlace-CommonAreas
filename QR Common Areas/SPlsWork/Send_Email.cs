using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_SEND_EMAIL
{
    public class UserModuleClass_SEND_EMAIL : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_FIELDS;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_TO;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_CC;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_SUBJECT;
        Crestron.Logos.SplusObjects.DigitalInput EDIT_MESSAGE;
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        Crestron.Logos.SplusObjects.StringInput FROM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SERVER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput USER_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput USER_PASSWORD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput TO__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput CC__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput SUBJECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput MESSAGE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SUCCESS;
        Crestron.Logos.SplusObjects.DigitalOutput PART_SUCCESS;
        Crestron.Logos.SplusObjects.DigitalOutput FAILURE;
        Crestron.Logos.SplusObjects.AnalogOutput ERROR_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput TO_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CC_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SUBJECT_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ERROR_TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TEXT_FB__DOLLAR__;
        object CLEAR_FIELDS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 77;
                _SplusNVRAM.STO  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 78;
                _SplusNVRAM.SCC  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 79;
                _SplusNVRAM.SSUBJECT  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 80;
                _SplusNVRAM.SMESSAGE  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 81;
                TO_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.STO  ) ; 
                __context__.SourceCodeLine = 82;
                CC_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SCC  ) ; 
                __context__.SourceCodeLine = 83;
                SUBJECT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SSUBJECT  ) ; 
                __context__.SourceCodeLine = 84;
                MESSAGE_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMESSAGE  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object EDIT_TO_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 90;
            TO_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.STO  ) ; 
            __context__.SourceCodeLine = 91;
            TEXT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.STO  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object EDIT_CC_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 97;
        CC_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SCC  ) ; 
        __context__.SourceCodeLine = 98;
        TEXT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SCC  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_SUBJECT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        SUBJECT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SSUBJECT  ) ; 
        __context__.SourceCodeLine = 105;
        TEXT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SSUBJECT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EDIT_MESSAGE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        MESSAGE_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMESSAGE  ) ; 
        __context__.SourceCodeLine = 112;
        TEXT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMESSAGE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 118;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.SSERVER ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.SFROM ) > 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.STO ) > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 120;
            PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 121;
            SUCCESS  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 122;
            FAILURE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 123;
            ERROR_TEXT__DOLLAR__  .UpdateValue ( "Sending e-mail. Please wait....."  ) ; 
            __context__.SourceCodeLine = 124;
            ERROR_NUMBER  .Value = (ushort) ( 1000 ) ; 
            __context__.SourceCodeLine = 126;
            _SplusNVRAM.IERROR = (short) ( SendMail( _SplusNVRAM.SSERVER , _SplusNVRAM.SNAME , _SplusNVRAM.SPASSWORD , _SplusNVRAM.SFROM , _SplusNVRAM.STO , _SplusNVRAM.SCC , _SplusNVRAM.SSUBJECT , _SplusNVRAM.SMESSAGE ) ) ; 
            __context__.SourceCodeLine = 135;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.IERROR >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 137;
                switch ((int)_SplusNVRAM.IERROR)
                
                    { 
                    case 0 : 
                    
                        { 
                        __context__.SourceCodeLine = 141;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 142;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 143;
                        SUCCESS  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 144;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Mail sent successfully."  ) ; 
                        __context__.SourceCodeLine = 145;
                        break ; 
                        } 
                    
                    goto case 3 ;
                    case 3 : 
                    
                        { 
                        __context__.SourceCodeLine = 149;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 150;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 151;
                        PART_SUCCESS  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 152;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message sent with an error in the To: list."  ) ; 
                        __context__.SourceCodeLine = 153;
                        break ; 
                        } 
                    
                    goto case 4 ;
                    case 4 : 
                    
                        { 
                        __context__.SourceCodeLine = 157;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 158;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 159;
                        PART_SUCCESS  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 160;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message sent with an error in the CC: list."  ) ; 
                        __context__.SourceCodeLine = 161;
                        break ; 
                        } 
                    
                    goto case 5 ;
                    case 5 : 
                    
                        { 
                        __context__.SourceCodeLine = 165;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 166;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 167;
                        PART_SUCCESS  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 168;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message sent with an error sending the message body."  ) ; 
                        __context__.SourceCodeLine = 169;
                        break ; 
                        } 
                    
                    goto default;
                    default : 
                    
                        { 
                        __context__.SourceCodeLine = 173;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 174;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 175;
                        PART_SUCCESS  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 176;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Unknown Error."  ) ; 
                        __context__.SourceCodeLine = 177;
                        break ; 
                        } 
                    break;
                    
                    } 
                    
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 183;
                _SplusNVRAM.IERROR = (short) ( Functions.ToSignedInteger( -( _SplusNVRAM.IERROR ) ) ) ; 
                __context__.SourceCodeLine = 184;
                switch ((int)_SplusNVRAM.IERROR)
                
                    { 
                    case 1 : 
                    
                        { 
                        __context__.SourceCodeLine = 188;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 189;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 190;
                        FAILURE  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 191;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error in Server, From: or To: field."  ) ; 
                        __context__.SourceCodeLine = 192;
                        break ; 
                        } 
                    
                    goto case 3 ;
                    case 3 : 
                    
                        { 
                        __context__.SourceCodeLine = 196;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 197;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 198;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 199;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error connceting to mail server."  ) ; 
                        __context__.SourceCodeLine = 200;
                        break ; 
                        } 
                    
                    goto case 4 ;
                    case 4 : 
                    
                        { 
                        __context__.SourceCodeLine = 204;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 205;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 206;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 207;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error sending the message."  ) ; 
                        __context__.SourceCodeLine = 208;
                        break ; 
                        } 
                    
                    goto case 6 ;
                    case 6 : 
                    
                        { 
                        __context__.SourceCodeLine = 212;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 213;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 214;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 215;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error preparing to send the message."  ) ; 
                        __context__.SourceCodeLine = 216;
                        break ; 
                        } 
                    
                    goto case 7 ;
                    case 7 : 
                    
                        { 
                        __context__.SourceCodeLine = 220;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 221;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 222;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 223;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error buffering the message."  ) ; 
                        __context__.SourceCodeLine = 224;
                        break ; 
                        } 
                    
                    goto case 8 ;
                    case 8 : 
                    
                        { 
                        __context__.SourceCodeLine = 228;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 229;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 230;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 231;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, error logging in to the server."  ) ; 
                        __context__.SourceCodeLine = 232;
                        break ; 
                        } 
                    
                    goto case 9 ;
                    case 9 : 
                    
                        { 
                        __context__.SourceCodeLine = 236;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 237;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 238;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 239;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, server does not support Authentication login."  ) ; 
                        __context__.SourceCodeLine = 240;
                        break ; 
                        } 
                    
                    goto default;
                    default : 
                    
                        { 
                        __context__.SourceCodeLine = 244;
                        SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 245;
                        PART_SUCCESS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 246;
                        FAILURE  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 247;
                        ERROR_TEXT__DOLLAR__  .UpdateValue ( "Message not sent, unknown error."  ) ; 
                        __context__.SourceCodeLine = 248;
                        break ; 
                        } 
                    break;
                    
                    } 
                    
                
                } 
            
            __context__.SourceCodeLine = 252;
            ERROR_NUMBER  .Value = (ushort) ( _SplusNVRAM.IERROR ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 259;
        _SplusNVRAM.SFROM  .UpdateValue ( Functions.Left ( FROM__DOLLAR__ ,  (int) ( 242 ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SERVER__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 265;
        _SplusNVRAM.SSERVER  .UpdateValue ( Functions.Left ( SERVER__DOLLAR__ ,  (int) ( 40 ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object USER_NAME__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 271;
        _SplusNVRAM.SNAME  .UpdateValue ( Functions.Left ( USER_NAME__DOLLAR__ ,  (int) ( 254 ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object USER_PASSWORD__DOLLAR___OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 277;
        _SplusNVRAM.SPASSWORD  .UpdateValue ( Functions.Left ( USER_PASSWORD__DOLLAR__ ,  (int) ( 254 ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TO__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 283;
        _SplusNVRAM.STO  .UpdateValue ( Functions.Left ( TO__DOLLAR__ ,  (int) ( 255 ) )  ) ; 
        __context__.SourceCodeLine = 284;
        TO_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.STO  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CC__DOLLAR___OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 290;
        _SplusNVRAM.SCC  .UpdateValue ( Functions.Left ( CC__DOLLAR__ ,  (int) ( 255 ) )  ) ; 
        __context__.SourceCodeLine = 291;
        CC_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SCC  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBJECT__DOLLAR___OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 297;
        _SplusNVRAM.SSUBJECT  .UpdateValue ( Functions.Left ( SUBJECT__DOLLAR__ ,  (int) ( 255 ) )  ) ; 
        __context__.SourceCodeLine = 298;
        SUBJECT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SSUBJECT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MESSAGE__DOLLAR___OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 304;
        _SplusNVRAM.SMESSAGE  .UpdateValue ( Functions.Left ( MESSAGE__DOLLAR__ ,  (int) ( 255 ) )  ) ; 
        __context__.SourceCodeLine = 305;
        MESSAGE_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMESSAGE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TEXT__DOLLAR___OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 311;
        _SplusNVRAM.STEMP  .UpdateValue ( TEXT__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 312;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDIT_TO  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 314;
            _SplusNVRAM.STO  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
            __context__.SourceCodeLine = 315;
            TO_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.STO  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 317;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDIT_CC  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 319;
                _SplusNVRAM.SCC  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
                __context__.SourceCodeLine = 320;
                CC_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SCC  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 322;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDIT_SUBJECT  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 324;
                    _SplusNVRAM.SSUBJECT  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
                    __context__.SourceCodeLine = 325;
                    SUBJECT_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SSUBJECT  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 327;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EDIT_MESSAGE  .Value == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 329;
                        _SplusNVRAM.SMESSAGE  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
                        __context__.SourceCodeLine = 330;
                        MESSAGE_FB__DOLLAR__  .UpdateValue ( _SplusNVRAM.SMESSAGE  ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 341;
        _SplusNVRAM.SFROM  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 342;
        _SplusNVRAM.SSERVER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 343;
        _SplusNVRAM.SNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 344;
        _SplusNVRAM.SPASSWORD  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 345;
        _SplusNVRAM.STO  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 346;
        _SplusNVRAM.SCC  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 347;
        _SplusNVRAM.SSUBJECT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 348;
        _SplusNVRAM.SMESSAGE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 349;
        _SplusNVRAM.IERROR = (short) ( 0 ) ; 
        __context__.SourceCodeLine = 350;
        ERROR_TEXT__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 351;
        ERROR_NUMBER  .Value = (ushort) ( 1000 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.SFROM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 242, this );
    _SplusNVRAM.SSERVER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    _SplusNVRAM.SNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    _SplusNVRAM.SPASSWORD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    _SplusNVRAM.STO  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _SplusNVRAM.SCC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _SplusNVRAM.SSUBJECT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _SplusNVRAM.SMESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _SplusNVRAM.STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    CLEAR_FIELDS = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_FIELDS__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_FIELDS__DigitalInput__, CLEAR_FIELDS );
    
    EDIT_TO = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_TO__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_TO__DigitalInput__, EDIT_TO );
    
    EDIT_CC = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_CC__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_CC__DigitalInput__, EDIT_CC );
    
    EDIT_SUBJECT = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_SUBJECT__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_SUBJECT__DigitalInput__, EDIT_SUBJECT );
    
    EDIT_MESSAGE = new Crestron.Logos.SplusObjects.DigitalInput( EDIT_MESSAGE__DigitalInput__, this );
    m_DigitalInputList.Add( EDIT_MESSAGE__DigitalInput__, EDIT_MESSAGE );
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    SUCCESS = new Crestron.Logos.SplusObjects.DigitalOutput( SUCCESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUCCESS__DigitalOutput__, SUCCESS );
    
    PART_SUCCESS = new Crestron.Logos.SplusObjects.DigitalOutput( PART_SUCCESS__DigitalOutput__, this );
    m_DigitalOutputList.Add( PART_SUCCESS__DigitalOutput__, PART_SUCCESS );
    
    FAILURE = new Crestron.Logos.SplusObjects.DigitalOutput( FAILURE__DigitalOutput__, this );
    m_DigitalOutputList.Add( FAILURE__DigitalOutput__, FAILURE );
    
    ERROR_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( ERROR_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ERROR_NUMBER__AnalogSerialOutput__, ERROR_NUMBER );
    
    FROM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FROM__DOLLAR____AnalogSerialInput__, 242, this );
    m_StringInputList.Add( FROM__DOLLAR____AnalogSerialInput__, FROM__DOLLAR__ );
    
    SERVER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SERVER__DOLLAR____AnalogSerialInput__, 40, this );
    m_StringInputList.Add( SERVER__DOLLAR____AnalogSerialInput__, SERVER__DOLLAR__ );
    
    USER_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( USER_NAME__DOLLAR____AnalogSerialInput__, 254, this );
    m_StringInputList.Add( USER_NAME__DOLLAR____AnalogSerialInput__, USER_NAME__DOLLAR__ );
    
    USER_PASSWORD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( USER_PASSWORD__DOLLAR____AnalogSerialInput__, 254, this );
    m_StringInputList.Add( USER_PASSWORD__DOLLAR____AnalogSerialInput__, USER_PASSWORD__DOLLAR__ );
    
    TO__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TO__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( TO__DOLLAR____AnalogSerialInput__, TO__DOLLAR__ );
    
    CC__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( CC__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( CC__DOLLAR____AnalogSerialInput__, CC__DOLLAR__ );
    
    SUBJECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( SUBJECT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( SUBJECT__DOLLAR____AnalogSerialInput__, SUBJECT__DOLLAR__ );
    
    MESSAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MESSAGE__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( MESSAGE__DOLLAR____AnalogSerialInput__, MESSAGE__DOLLAR__ );
    
    TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXT__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( TEXT__DOLLAR____AnalogSerialInput__, TEXT__DOLLAR__ );
    
    TO_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_FB__DOLLAR____AnalogSerialOutput__, TO_FB__DOLLAR__ );
    
    CC_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CC_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CC_FB__DOLLAR____AnalogSerialOutput__, CC_FB__DOLLAR__ );
    
    SUBJECT_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SUBJECT_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUBJECT_FB__DOLLAR____AnalogSerialOutput__, SUBJECT_FB__DOLLAR__ );
    
    MESSAGE_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE_FB__DOLLAR____AnalogSerialOutput__, MESSAGE_FB__DOLLAR__ );
    
    ERROR_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ERROR_TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ERROR_TEXT__DOLLAR____AnalogSerialOutput__, ERROR_TEXT__DOLLAR__ );
    
    TEXT_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TEXT_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TEXT_FB__DOLLAR____AnalogSerialOutput__, TEXT_FB__DOLLAR__ );
    
    
    CLEAR_FIELDS.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_FIELDS_OnPush_0, false ) );
    EDIT_TO.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_TO_OnPush_1, false ) );
    EDIT_CC.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_CC_OnPush_2, false ) );
    EDIT_SUBJECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_SUBJECT_OnPush_3, false ) );
    EDIT_MESSAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( EDIT_MESSAGE_OnPush_4, false ) );
    SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_5, false ) );
    FROM__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM__DOLLAR___OnChange_6, false ) );
    SERVER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SERVER__DOLLAR___OnChange_7, false ) );
    USER_NAME__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( USER_NAME__DOLLAR___OnChange_8, false ) );
    USER_PASSWORD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( USER_PASSWORD__DOLLAR___OnChange_9, false ) );
    TO__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO__DOLLAR___OnChange_10, false ) );
    CC__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CC__DOLLAR___OnChange_11, false ) );
    SUBJECT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( SUBJECT__DOLLAR___OnChange_12, false ) );
    MESSAGE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MESSAGE__DOLLAR___OnChange_13, false ) );
    TEXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TEXT__DOLLAR___OnChange_14, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SEND_EMAIL ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CLEAR_FIELDS__DigitalInput__ = 0;
const uint EDIT_TO__DigitalInput__ = 1;
const uint EDIT_CC__DigitalInput__ = 2;
const uint EDIT_SUBJECT__DigitalInput__ = 3;
const uint EDIT_MESSAGE__DigitalInput__ = 4;
const uint SEND__DigitalInput__ = 5;
const uint FROM__DOLLAR____AnalogSerialInput__ = 0;
const uint SERVER__DOLLAR____AnalogSerialInput__ = 1;
const uint USER_NAME__DOLLAR____AnalogSerialInput__ = 2;
const uint USER_PASSWORD__DOLLAR____AnalogSerialInput__ = 3;
const uint TO__DOLLAR____AnalogSerialInput__ = 4;
const uint CC__DOLLAR____AnalogSerialInput__ = 5;
const uint SUBJECT__DOLLAR____AnalogSerialInput__ = 6;
const uint MESSAGE__DOLLAR____AnalogSerialInput__ = 7;
const uint TEXT__DOLLAR____AnalogSerialInput__ = 8;
const uint SUCCESS__DigitalOutput__ = 0;
const uint PART_SUCCESS__DigitalOutput__ = 1;
const uint FAILURE__DigitalOutput__ = 2;
const uint ERROR_NUMBER__AnalogSerialOutput__ = 0;
const uint TO_FB__DOLLAR____AnalogSerialOutput__ = 1;
const uint CC_FB__DOLLAR____AnalogSerialOutput__ = 2;
const uint SUBJECT_FB__DOLLAR____AnalogSerialOutput__ = 3;
const uint MESSAGE_FB__DOLLAR____AnalogSerialOutput__ = 4;
const uint ERROR_TEXT__DOLLAR____AnalogSerialOutput__ = 5;
const uint TEXT_FB__DOLLAR____AnalogSerialOutput__ = 6;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public short IERROR = 0;
            [SplusStructAttribute(1, false, true)]
            public CrestronString SFROM;
            [SplusStructAttribute(2, false, true)]
            public CrestronString SSERVER;
            [SplusStructAttribute(3, false, true)]
            public CrestronString SNAME;
            [SplusStructAttribute(4, false, true)]
            public CrestronString SPASSWORD;
            [SplusStructAttribute(5, false, true)]
            public CrestronString STO;
            [SplusStructAttribute(6, false, true)]
            public CrestronString SCC;
            [SplusStructAttribute(7, false, true)]
            public CrestronString SSUBJECT;
            [SplusStructAttribute(8, false, true)]
            public CrestronString SMESSAGE;
            [SplusStructAttribute(9, false, true)]
            public CrestronString STEMP;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
