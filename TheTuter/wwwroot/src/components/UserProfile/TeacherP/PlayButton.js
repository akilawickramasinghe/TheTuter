import React,{useState} from 'react';
import {Button,Modal} from 'react-bootstrap';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import PlayCircleFilled from '@material-ui/icons/PlayCircleFilled';
import MyPlayer from './Player';
import './modal.css';
import CloseIcon from '@material-ui/icons/Close';





export default function PlayButton(props) {
  const [show, setShow] = useState(false);

  return (
    <>
      <Button variant="outline-primary"  className="playbutton" onClick={() => setShow(true)}>
      <ListItemIcon style={{marginLeft:'0px', marginTop:'-4px'}} size="sm">
        <PlayCircleFilled/>
      </ListItemIcon>
      </Button>

      <Modal
        show={show}
        onHide={() => setShow(false)}
        size="xl"
        className="modal"
        centered
        
      >
        <Modal.Header style={{height:'30px'}} >
          <Button 
            variant="danger" 
            onClick={() => setShow(false)}
            style={{marginLeft:'1090px', height:'30px', width:'30px'}} 
          >
            <ListItemIcon className="closebutton" style={{color:'white'}}>
            <CloseIcon/>
            </ListItemIcon>
          </Button>
        </Modal.Header>

        <Modal.Body>
          <p>
          <MyPlayer src={props.path} style={{marginLeft:"10px"}}/>
          </p>
        </Modal.Body>
      </Modal>
    </>
  );
}
