# 🛠️ CAN_DB_EDITOR Ver 1.0

CAN_DB_EDITOR는 CAN 통신용 데이터베이스(CAN DB)를 시각적으로 편집, 생성, 저장할 수 있는 WinForms 기반 도구입니다.  
간단한 사용자 인터페이스를 통해 메시지 및 신호 정보를 관리할 수 있으며, 향후 DBC 호환 및 시뮬레이션 기능도 계획되어 있습니다.

---

## 📦 프로젝트 개요

- **이름**: CAN_DB_EDITOR  
- **버전**: 1.0  
- **플랫폼**: Windows (.NET Framework 4.8)  
- **UI 프레임워크**: Windows Forms  
- **주요 목적**: CAN DB 생성 및 시각적 편집

---

## 🔧 주요 기능

- ✅ CAN 메시지 추가/수정/삭제
- ✅ CAN 신호(Signal) 정보 편집
- ✅ 메시지 테이블 시각화 (DataGridView)
- ✅ JSON 기반 저장 (`.candb`)
- ✅ 이름/ID/신호 필터 검색
- ✅ 중복 ID 및 비트 충돌 검사

---

## 🖥️ UI 구성

- **왼쪽**: 메시지 목록 (ListBox / TreeView)
- **가운데**: 메시지/신호 테이블 보기 (DataGridView)
- **오른쪽**: 속성 편집 영역 (PropertyGrid)
- **하단**: 상태 로그 및 알림 영역

---

## 🗂️ 파일 구조 예시 (.candb)

```json
{
  "version": "1.0",
  "messages": [
    {
      "name": "EngineData",
      "id": 256,
      "dlc": 8,
      "transmitter": "ECU1",
      "signals": [
        {
          "name": "RPM",
          "startBit": 0,
          "length": 16,
          "isLittleEndian": true,
          "isSigned": false,
          "factor": 0.125,
          "offset": 0,
          "min": 0,
          "max": 8000,
          "unit": "rpm"
        }
      ]
    }
  ]
}
