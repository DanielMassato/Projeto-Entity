unit Unit1;

interface

uses SysUtils, Classes, QGraphics, QForms, QControls, QStdCtrls, 
  QButtons, QExtCtrls, QLiveSpeedButton, QT;

type
  TFORM1 = class(TForm)
    edPassword: TEdit;
    edLogin: TEdit;
    Image1: TImage;
    Label2: TLabel;
    Label1: TLabel;
    btnOk: TLiveSpeedButton;
    procedure btnOkClick(Sender: TObject);
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FORM1: TFORM1;

implementation

{$R *.xfm}

procedure TFORM1.btnOkClick(Sender: TObject);
begin
Close;
end;

procedure TFORM1.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
if (Key = Key_Enter) or (Key = Key_Down) or (Key = Key_Return) then
   if ActiveControl = edLogin then SelectNext(ActiveControl,True,True)
                              else btnOk.Click;
end;

end.
 
