import React from "react";
import { withStyles } from "@material-ui/core/styles";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import IconButton from "@material-ui/core/IconButton";
import Typography from "@material-ui/core/Typography";
import MenuIcon from "@material-ui/icons/Menu";
import Grid from '@material-ui/core/Grid';
import Button from '@material-ui/core/Button'
import {indigo} from '@material-ui/core/colors';
import { Link } from 'react-router-dom';




const styles = theme => ({

  root: {
    flexGrow: 0,
    
    
  },

  nav: {
    backgroundColor:indigo[300],
  },

  menu: {
    backgroundColor:indigo[500],
  },

  
  menuButton: {
    marginRight: theme.spacing(0)
    
  },
  title: {
    display: "none",
    padding: theme.spacing(1, 1, 1, 1),
    [theme.breakpoints.up("sm")]: {
      display: "block"
    }
  },
  
  inputRoot: {
    color: "inherit"
  },
  inputInput: {
    padding: theme.spacing(1, 1, 1, 7),
    transition: theme.transitions.create("width"),
    width: "100%",
    [theme.breakpoints.up("md")]: {
      width: 200
    }
  },
  
});

class ToolbarComponent extends React.Component {
  

  render() {
    const { classes } = this.props;
    return (
      
      <div className={classes.root}>
        <Grid item xs={12} container spacing={0} >
        <Grid item xs={2} className={classes.menu}  >
        
          <Toolbar>
            <IconButton
              edge="start"
              className={classes.menuButton}
              color="inherit"
              aria-label="open drawer"
              onClick={this.props.openDrawerHandler} >
              <MenuIcon />
              <Typography variant="subtitle2" className={classes.title}> COURSE CATEGORIES </Typography>
            </IconButton>

          </Toolbar>
       
        </Grid>
         
        <Grid  container justify="space-evenly" alignItems="center" item xs={10} className={classes.nav}  >

           
           <Link style={{color:"black", textDecoration:"none"}} to="/">HOME </Link>
           <Link style={{color:"black", textDecoration:"none"}} to="/about">ABOUT </Link>
           <Link style={{color:"black", textDecoration:"none"}} to="/institute">INSTITUTES </Link>
           <Link style={{color:"black", textDecoration:"none"}} to="/teacherR">BECOME A TEACHER </Link>
           <Link style={{color:"black", textDecoration:"none"}} to="/studentR2">BECOME A STUDENT </Link>
           <Link style={{color:"black", textDecoration:"none"}} to="/contact">CONTACT </Link>
           

        </Grid>
        </Grid>
      </div>
     
    );
  }
}

export default withStyles(styles)(ToolbarComponent);


        
      
    