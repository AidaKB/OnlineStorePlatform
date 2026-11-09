import { DarkMode } from "@mui/icons-material";
import LightMode from "@mui/icons-material/LightMode";
import { AppBar, IconButton, Toolbar, Typography } from "@mui/material";

type Props = {
    darkMode: boolean;
    toggleDarkMode: () => void;
}

export default function NavBar({ darkMode, toggleDarkMode }: Props) {
    return (
        <AppBar position="fixed">
            <Toolbar>
                <Typography variant="h6">
                    RE-STORE
                </Typography>
                <IconButton
                    color="inherit"
                    onClick={toggleDarkMode}
                    aria-label={darkMode? "dark mode is on": "light mode is on" }
                >
                    {darkMode? <DarkMode/> : <LightMode/>}
                </IconButton>
            </Toolbar>
        </AppBar>
    );
}