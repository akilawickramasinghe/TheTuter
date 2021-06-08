import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
//import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import Image from '../../images/logo.png'
import {indigo,grey} from '@material-ui/core/colors';
import { createMuiTheme} from '@material-ui/core'
//import { positions } from '@material-ui/system';
import StudentR from '../Register/StudentR'
import { Link } from 'react-router-dom';
import SignIn from '../SignIn/SignIn'

const theme =createMuiTheme({
  palette:{
    primary:{
      main:grey[900]
    },
    secondary: {
      main: indigo[900]
    },
  }
})


const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
    backgroundColor:grey[300],
    padding: theme.spacing(2),
  },
  paper: {
    padding: theme.spacing(2),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  },

  title: {
    
    fontSize:20,
    flexGrow: 1,
    color:indigo[600],
    textAlign: 'center',

   
  },

  button: {

    flexGrow: 1,

    '& > *': {
      margin: theme.spacing(1),
      
    },
  },
  
}));


export default function Header() {
  const classes = useStyles();

  


  return (
    <div className={classes.root}>
      <Grid container spacing={0}  >
        <Grid item xs={4} >
         <img src={Image} width ='100' alt="logo" ></img>
        </Grid>
        <Grid container alignItems="center" justify="center" item xs={4} className={classes.title} >
          <h1>  ONLINE EDUCATION</h1>
        </Grid>
        <Grid container alignItems="center" justify="flex-end"   item xs={4} className={classes.button} >
            
            <StudentR />
            <SignIn />
            
            
        </Grid>
      </Grid>
    </div>
    
  );
}

/*<Link style={{color:"black", textDecoration:"none"}} to="./accSTmenu"> 
              <Button variant="contained" color="primary"> Login </Button> 
            </Link> */