import React from 'react';
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
import Card from 'react-bootstrap/Card'
import { AccountBox, AddAlert, Home } from '@material-ui/icons';
import UserHeader from '../StudentP/UserHeader'
import SearchIcon from '@material-ui/icons/Search';
import InputBase from '@material-ui/core/InputBase';
import { fade } from '@material-ui/core/styles';
import Footer from '../../Footer/Footer'
import Image from '../../../images/q.png'
import Table from './Subscriptionstable';

const theme =createMuiTheme({
  palette:{
    primary:{
      main:indigo[500]
    }
  }
})


const drawerWidth = 240;

const useStyles = makeStyles((theme) => ({


  rooot: {
    width: '100%',
    maxWidth: 360,
    backgroundColor: theme.palette.background.paper,
  },
  nested: {
    paddingLeft: theme.spacing(4),
  },
  root: {
    display: 'flex',
    
   },

  
  toolbar: {
    paddingRight: 24, // keep right padding when drawer closed
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
    maxHeight : '520px',    
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

export default function AccSTsubscriptions() {
  var f = localStorage.getItem('FirstName');
  var l = localStorage.getItem('LastName');
  var fn = f+" "+l;
  const classes = useStyles();
  const [fullName, setFullName] = React.useState(fn);
  const [open, setOpen] = React.useState(true);
  const handleDrawerOpen = () => {
    setOpen(true);
  };
  const handleDrawerClose = () => {
    setOpen(false);
  };


  const fixedHeightPaper = clsx(classes.paper, classes.fixedHeight);

 
  return (
    <div>
    <UserHeader />
    <div className="background">


 {/* Top bar */}  

  <MuiThemeProvider theme={theme} >
     
   <div className={classes.root}>
      <CssBaseline />
      <AppBar position="absolute" className={clsx(classes.appBar, open && classes.appBarShift)}>
        <Toolbar className={clsx(classes.toolbar )}>
          <IconButton
            edge="start"
            color="inherit"
            aria-label="open drawer"
            onClick={handleDrawerOpen}
            className={clsx(classes.menuButton, open && classes.menuButtonHidden)}
          >
           <MenuIcon /> 

          </IconButton>
          <Typography component="h1" variant="h5" color="inherit" noWrap className={(classes.title)} style={{fontWeight:'Bold'}}>
            STUDENT PROFILE
          </Typography>

          {/* 

          Default:-

          <IconButton color="inherit">
            <Badge badgeContent={4} color="secondary">
              <NotificationsIcon/>
            </Badge>
          </IconButton>
          <IconButton color="inherit">
            <Avatar style={{backgroundColor:'#1a237e'}}  />
          </IconButton> 

          */}

         
       {/* Search Bar */}
       {/* <div className={classes.search}>            
            <div className={classes.searchIcon}>
              <SearchIcon />
            </div>
             <InputBase
              placeholder="Search"
              classes={{
                root: classes.inputRoot,
                input: classes.inputInput,
              }}/>
          </div> */}


        </Toolbar>
      </AppBar>
      


{/* Drawer */}

      <Drawer
        
        variant="permanent"
        classes={{
          paper: clsx(classes.drawerPaper, !open && classes.drawerPaperClose),
        }}
        open={open}
      >
        <div className={classes.toolbarIcon}>
          <IconButton onClick={handleDrawerClose}>
            <ChevronLeftIcon />
          </IconButton>
        </div>
        <Divider />
        
        
        <List>

      <ListItem button>
      <ListItemIcon style={{color:"white"}}>
        < AccountBox />
      </ListItemIcon>
      <ListItemText primary={fullName} />
      </ListItem>
    
        <ListItem Avatar>
              <Avatar className="avatar " style={{width:'120px' , height:'120px'}}>
                <img
                  src={Image}
                  alt=""
                  className="rounded-circle img-fluid"
                />
              </Avatar>
        </ListItem>   

   <Link style={{color:"black", textDecoration:"none"}} to="./AccSTmenu">  
    <ListItem button>
      <ListItemIcon style={{color:"white"}}>
        < Home />
      </ListItemIcon>
      <ListItemText style={{color:"white"}} primary="Main Menu" />
    </ListItem>
    </Link>
    
    {/*
    <ListItem button>
      <ListItemIcon style={{color:"white"}}>
        <LocalPostOfficeIcon />
      </ListItemIcon>
      <ListItemText primary="Inbox"  />
    </ListItem>
    */}


  <ListItem button>
      <ListItemIcon style={{color:"white"}}>
        < AddAlert />
      </ListItemIcon>
      <ListItemText style={{color:"white"}} primary="Subscriptions" />
    </ListItem>
    
    <Link style={{color:"black", textDecoration:"none"}} to="./AccSTQuiz">
  <ListItem button>
      <ListItemIcon style={{color:"white"}}>
        <AddAlert />
      </ListItemIcon>
      <ListItemText style={{color:"white"}} primary="Attempt Quiz" />
    </ListItem>
    </Link>
    
        </List>
    </Drawer> 

    

{/*Content box*/}

      <main className={classes.content}>
      <div className={classes.appBarSpacer} />

        <Container style={{width:'900px'}} className={classes.container}>
          <Grid container >
          
           {/* list of uploaded videos */}
             <Grid item xs={12} lg={12}>
              <Paper className={classes.paper}>

              <Table/>

              </Paper>
            </Grid>
            </Grid>   
        </Container> 
      </main>
    </div> 
  </MuiThemeProvider> 
</div>
<Footer />
   </div>         
  );
}
