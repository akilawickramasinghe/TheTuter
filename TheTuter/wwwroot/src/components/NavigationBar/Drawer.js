import React from "react";
import Drawer from "@material-ui/core/Drawer";
import withStyles from "@material-ui/core/styles/withStyles";
import {
  List,
  ListItem,
  ListItemText,
} from "@material-ui/core";


const styles = theme => ({
  list: {
    width: 250
  },
  fullList: {
    width: "auto"
  }
});

class DrawerComponent extends React.Component {
  state = {
    left: false
  };

  render() {
    const { classes } = this.props;

    const sideList = side => (
      <div
        className={classes.list}

        onClick={this.props.toggleDrawerHandler}
        onKeyDown={this.props.toggleDrawerHandler}
      >
        <List>
          {["BIOLOGY", "PHYSICS", "CHEMISTRY", "COMBINED MATHEMATICS","O/L - SCIENCE", "O/L - MATHEMATICS", 
          "O/L - COMMERCE", "O/L - MUSIC"].map((text, index) => (
            <ListItem button key={text}>
              <ListItemText primary={text} />
            </ListItem>
          ))}
        </List>

      </div>
    );

    return (
      <Drawer open={this.props.left} onClose={this.props.toggleDrawerHandler}>
        {sideList("left")}
      </Drawer>
    );
  }
}

export default withStyles(styles)(DrawerComponent);
