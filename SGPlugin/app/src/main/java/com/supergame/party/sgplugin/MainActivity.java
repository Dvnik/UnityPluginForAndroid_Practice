package com.supergame.party.sgplugin;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

import android.app.AlertDialog;
import android.os.Bundle;
import android.app.Activity;

public class MainActivity extends UnityPlayerActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
    }

    public static Activity getActivity()
    {
        return UnityPlayer.currentActivity;
    }

    // TestFunction Start---------------------------------------------------------------------------
    public static void AlertShow(final String title, final String content)
    {
        getActivity().runOnUiThread(new Runnable() {
            public void run() {
                AlertDialog.Builder builder = new AlertDialog.Builder(getActivity());
                builder.setTitle(title).setMessage(content).setCancelable(false).setPositiveButton("OK", null);
                builder.show();
            }
        });
    }

    // TestFunction End-----------------------------------------------------------------------------
}
