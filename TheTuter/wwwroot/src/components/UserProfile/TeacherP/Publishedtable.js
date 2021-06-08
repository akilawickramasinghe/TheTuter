import React, { useState, useEffect } from 'react'
import axios from 'axios'
import './table.css';
import PlayButton from './PlayButton';

import clsx from 'clsx';
import { makeStyles } from '@material-ui/core/styles';
import CssBaseline from '@material-ui/core/CssBaseline';
import Drawer from '@material-ui/core/Drawer';
import Box from '@material-ui/core/Box';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import List from '@material-ui/core/List';
import Typography from '@material-ui/core/Typography';
import Divider from '@material-ui/core/Divider';
import IconButton from '@material-ui/core/IconButton';
import Avatar from '@material-ui/core/Avatar';
import Badge from '@material-ui/core/Badge';
import Container from '@material-ui/core/Container';
import Grid from '@material-ui/core/Grid';
import Paper from '@material-ui/core/Paper';
import { Link } from 'react-router-dom'
import MenuIcon from '@material-ui/icons/Menu';
import ChevronLeftIcon from '@material-ui/icons/ChevronLeft';
import NotificationsIcon from '@material-ui/icons/Notifications';
import { teal, green, cyan, indigo, grey, blueGrey,  } from '@material-ui/core/colors';
import {MuiThemeProvider , createMuiTheme, ListItemAvatar} from '@material-ui/core';
import ExitToApp from '@material-ui/icons/ExitToApp';
import '../../UserProfile/StudentP/AccST.css';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import DashboardIcon from '@material-ui/icons/Dashboard';
import AssignmentIcon from '@material-ui/icons/Assignment';
import LocalPostOfficeIcon from '@material-ui/icons/LocalPostOffice';
import CalendarTodayIcon from '@material-ui/icons/CalendarToday';
import QuestionAnswerIcon from '@material-ui/icons/QuestionAnswer';
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'
import FormControl from 'react-bootstrap/FormControl'
//import AlignItemsList from './App'
//import { MDBContainer, MDBRow, MDBCol, MDBCard, MDBCardUp, MDBCardBody, MDBIcon } from "mdbreact";
//import Card from 'react-bootstrap/Card'
import { AccountBox, AddAlert, Home } from '@material-ui/icons';
import UserHeader from '../StudentP/UserHeader'
import SearchIcon from '@material-ui/icons/Search';
import InputBase from '@material-ui/core/InputBase';
import { fade } from '@material-ui/core/styles';



const URL = 'https://jsonplaceholder.typicode.com/users';

const drawerWidth = 240;

const useStyles = makeStyles((theme) => ({

  root: {
    display: 'flex',
   },

  
  toolbar: {
    paddingRight: 2, // keep right padding when drawer closed
  },
  toolbarIcon: {
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'flex-end',
    padding: '0 8px',
    ...theme.mixins.toolbar,
  },
  appBar: {
   
    zIndex: theme.zIndex.drawer + 1,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
      
    }),
  },
  appBarShift: {
    marginLeft: drawerWidth,
    width: `calc(100% - ${drawerWidth}px)`,
    transition: theme.transitions.create(['width', 'margin'], {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
   
    }),
  },
  menuButton: {
    marginRight: 36,
  },
  menuButtonHidden: {
    display: 'none',
  },
  title: {
    flexGrow: 1,
  },
  drawerPaper: {
    color:"white",
    backgroundColor:grey[900],
    position: 'relative',
    whiteSpace: 'nowrap',
    
    /*width: drawerWidth,*/
    width: '240px',
    transition: theme.transitions.create('width', {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.enteringScreen,
    }),
  },
  drawerPaperClose: {
    overflowX: 'hidden',
    transition: theme.transitions.create('width', {
      easing: theme.transitions.easing.sharp,
      duration: theme.transitions.duration.leavingScreen,
    }),


    width: theme.spacing(7),
    [theme.breakpoints.up('sm')]: {
      width: theme.spacing(7),
    },
  },
  appBarSpacer: theme.mixins.toolbar,
  content: {
    flexGrow: 1,
    height: '100vh',
    paddingTop: theme.spacing(5),
    paddingBottom: theme.spacing(10),
  },
  
  paper: {
    padding: theme.spacing(2),
    maxHeight : '720px',    
    overflow: 'auto',
    flexDirection: 'column',
  },
  fixedHeight: {
    height: 240,
  },

  search: {
    position: 'relative',
    borderRadius: theme.shape.borderRadius,
    backgroundColor: fade(theme.palette.common.white, 0.55),
    '&:hover': {
      backgroundColor: fade(theme.palette.common.white, 0.75),
    },
    marginRight: theme.spacing(5),
    marginLeft: 0,
    width: '100%',
    [theme.breakpoints.up('sm')]: {
      marginLeft: theme.spacing(20),
      width: 'auto',
    },
  },
  searchIcon: {
    padding: theme.spacing(0, 2),
    height: '100%',
    position: 'absolute',
    pointerEvents: 'none',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
  },

  inputInput: {
    padding: theme.spacing(1, 1, 1, 0),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc(1em + ${theme.spacing(4)}px)`,
    transition: theme.transitions.create('width'),
    width: '100%',
    [theme.breakpoints.up('md')]: {
      width: '30ch',
    },
  },
}));


const Table = (props) => {
    const classes = useStyles();
    const [courses, setCourses] = useState([]);

    const handleChange =(async event => {
        var searchTerm  = event.target.value;
        try {
                const res = await axios.get('/Students/GetAllLectureByTeacherId?searchTerm='+searchTerm);
                debugger
                setCourses(res.data)
            } catch (ex) {
                setCourses(null);
            }
    });

  useEffect(() => {
    async function fetchData() {
      // You can await here
      try {
        // var stdId = localStorage.getItem('UserId');
        const res = await axios.get('/Students/GetAllLectureByTeacherId?searchTerm=' + "");
        debugger
        setCourses(res.data)
      } catch (ex) {
        setCourses(null);
      }
      // ...
    }
    fetchData();
  }, []);

    // const getData = async () => {
    //     const response = await axios.get(URL)
    //     setCourses(response.data)
    // }


    const renderHeader = () => {
        let headerElement = [ 'batch', 'class', 'lesson', 'operation']
        return headerElement.map((key, index) => {
            return <th key={index}>{key.toUpperCase()}</th>
        })
    }

        const renderBody = () => {
            return courses?.map(data => {
                return  (
                    <tr key={data.userId}>
                        <td style={{ width: '200px' }}>{data.batch}</td>
                        <td style={{ width: '150px' }}>{data.class}</td>
                        <td style={{ width: '150px' }}>{data.lesson}</td>
                        <td style={{ width: '270px' }}>
                            <strong >
                                <PlayButton path={data.path}/>
                            </strong>
                        </td>
                    </tr>
                )
            });
        }    


    return (
        <div class="tableFixHead">
            <span>
            <SearchIcon />
            <InputBase
                onChange={handleChange}
                placeholder="Search By Class"
                classes={{
                    root: classes.inputRoot,
                    input: classes.inputInput,
                }}
            />
        </span>
            <table id='courses'>
                <thead >
                    <tr>{renderHeader()}</tr>
                </thead>
                <tbody >
                    {renderBody()}
                </tbody>
            </table>
        </div>
    )
}


export default Table