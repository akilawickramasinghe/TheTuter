import React from 'react';
import 'react-dropzone-uploader/dist/styles.css';
import Dropzone from 'react-dropzone-uploader';

// preview component
const Preview = ({ meta }) => {
  const { name, percent, status, previewUrl } = meta;
  return (
    <div className="preview-box">
      <img src={previewUrl} /> <span className="name">{name}</span> - <span className="status">{status}</span>{status !== "done" && <span className="percent">&nbsp;({Math.round(percent)}%)</span>}
    </div>
  )
}

function Upload() {
  // specify upload params and API url to file upload
  const getUploadParams = ({ file }) => {
    const body = new FormData();
    body.append('dataFiles', file);
    debugger
    return { url: '/Teachers/UploadLecture', body }
  }

  // handle the status of the file upload
  const handleChangeStatus = ({ xhr }) => {
    if (xhr) {
      xhr.onreadystatechange = () => {
        if (xhr.readyState === 4) {
          const result = JSON.parse(xhr.response);
          console.log(result);
        }
      }
    }
  }

  return (
    <div className="App">
      <div>
        <Dropzone
          getUploadParams={getUploadParams}
          onChangeStatus={handleChangeStatus}
          styles={{
            dropzone: { overflow: 'auto', border: '3px dashed #eeeeee', background: '#f5f5f5' },
            inputLabelWithFiles: { margin: '20px 1%' }
          }}
          canRemove={true}
          PreviewComponent={Preview}
          accept="image/*,audio/*,video/*"
        />
      </div>
    </div>
  );
}

export default Upload;
